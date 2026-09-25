using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace text_editor_windows_forms_misha
{
    public partial class Form1 : Form
    {
        private string fileName = null;   // путь к открытому файлу (null — документ ещё не сохранён)
        private string lastSearch = "";   // последняя искомая строка (для F3 и Shift+F3)
        private FindForm findForm = null; // открытое окно поиска/замены

        public Form1()
        {
            InitializeComponent();
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            string name = fileName == null ? "Безымянный" : Path.GetFileName(fileName);
            Text = name + " — Текстовый редактор";
        }

        // ===================== Файл =====================

        // Если текст изменён — спрашивает, сохранить ли его.
        // Возвращает false, если пользователь нажал «Отмена» (действие нужно прервать).
        private bool ConfirmSave()
        {
            if (!richTextBox.Modified)
                return true;
            DialogResult answer = MessageBox.Show("Сохранить изменения?", "Текстовый редактор",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                return Save();
            return answer == DialogResult.No;
        }

        private bool Save()
        {
            if (fileName == null)
                return SaveAs();
            return WriteFile(fileName);
        }

        private bool SaveAs()
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return false;
            return WriteFile(saveFileDialog1.FileName);
        }

        // .rtf хранит текст вместе с форматированием, остальные файлы — простой текст
        private static bool IsRtf(string path)
        {
            return Path.GetExtension(path).ToLower() == ".rtf";
        }

        // Убирает форматирование, оставшееся от прошлого документа: шрифт по умолчанию, выравнивание влево
        private void ResetFormat()
        {
            richTextBox.SelectAll();
            richTextBox.SelectionFont = richTextBox.Font;
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.Select(0, 0);
        }

        private bool WriteFile(string path)
        {
            try
            {
                if (IsRtf(path))
                    richTextBox.SaveFile(path, RichTextBoxStreamType.RichText);
                else // RichTextBox хранит конец строки как "\n", а в текстовых файлах Windows принят "\r\n"
                    File.WriteAllText(path, richTextBox.Text.Replace("\n", "\r\n"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            fileName = path;
            richTextBox.Modified = false;
            UpdateTitle();
            return true;
        }

        private void newItem_Click(object sender, EventArgs e)
        {
            if (!ConfirmSave())
                return;
            richTextBox.Clear();
            ResetFormat();
            richTextBox.ClearUndo();
            richTextBox.Modified = false;
            fileName = null;
            UpdateTitle();
        }

        private void newWindowItem_Click(object sender, EventArgs e)
        {
            // Запускаем ещё один экземпляр программы — новое независимое окно
            Process.Start(Application.ExecutablePath);
        }

        private void openItem_Click(object sender, EventArgs e)
        {
            if (!ConfirmSave())
                return;
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                if (IsRtf(openFileDialog1.FileName))
                    richTextBox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                else
                {
                    richTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
                    ResetFormat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            richTextBox.ClearUndo();
            richTextBox.Modified = false;
            fileName = openFileDialog1.FileName;
            UpdateTitle();
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveAsItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            Close(); // вопрос о сохранении задаётся в Form1_FormClosing
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmSave())
                e.Cancel = true;
        }

        // ===================== Правка =====================

        // Перед открытием меню делаем недоступными команды, которые сейчас нечего выполнять
        private void editMenu_DropDownOpening(object sender, EventArgs e)
        {
            bool hasSelection = richTextBox.SelectionLength > 0;
            undoItem.Enabled = richTextBox.CanUndo;
            cutItem.Enabled = hasSelection;
            copyItem.Enabled = hasSelection;
            deleteItem.Enabled = hasSelection;
            pasteItem.Enabled = Clipboard.ContainsText();
        }

        private void undoItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void cutItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void copyItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void pasteItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectedText = ""; // заменить выделение пустой строкой (у RichTextBox это можно отменить)
        }

        private void findItem_Click(object sender, EventArgs e)
        {
            ShowFindForm(false);
        }

        private void replaceItem_Click(object sender, EventArgs e)
        {
            ShowFindForm(true);
        }

        private void findNextItem_Click(object sender, EventArgs e)
        {
            if (lastSearch == "")
                ShowFindForm(false);
            else
                FindText(lastSearch, true);
        }

        private void findPrevItem_Click(object sender, EventArgs e)
        {
            if (lastSearch == "")
                ShowFindForm(false);
            else
                FindText(lastSearch, false);
        }

        private void ShowFindForm(bool replaceMode)
        {
            if (findForm != null && !findForm.IsDisposed)
                findForm.Close();
            findForm = new FindForm(this, replaceMode, lastSearch);
            findForm.Show(this); // немодально: можно продолжать работать с текстом
        }

        // Ищет строку what от текущего выделения вниз или вверх и выделяет найденное.
        public bool FindText(string what, bool down)
        {
            lastSearch = what;
            string text = richTextBox.Text;
            int index;
            if (down)
                index = text.IndexOf(what, richTextBox.SelectionStart + richTextBox.SelectionLength, StringComparison.Ordinal);
            else
                index = text.Substring(0, richTextBox.SelectionStart).LastIndexOf(what, StringComparison.Ordinal);

            if (index < 0)
            {
                MessageBox.Show("Не удается найти \"" + what + "\"", "Текстовый редактор",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            richTextBox.Select(index, what.Length);
            richTextBox.ScrollToCaret();
            return true;
        }

        // Заменяет текущее выделение (если это искомая строка) и ищет следующее вхождение.
        public void ReplaceText(string what, string with, bool down)
        {
            if (richTextBox.SelectedText == what)
                richTextBox.SelectedText = with;
            FindText(what, down);
        }

        public void ReplaceAll(string what, string with)
        {
            lastSearch = what;
            if (!richTextBox.Text.Contains(what))
            {
                MessageBox.Show("Не удается найти \"" + what + "\"", "Текстовый редактор",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Заменяем каждое вхождение по отдельности через выделение,
            // чтобы у остального текста сохранились шрифты и выравнивание
            int index = richTextBox.Text.IndexOf(what, StringComparison.Ordinal);
            while (index >= 0)
            {
                richTextBox.Select(index, what.Length);
                richTextBox.SelectedText = with;
                index = richTextBox.Text.IndexOf(what, index + with.Length, StringComparison.Ordinal);
            }
        }

        private void goToItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox.Text;
            // Строки разделяются символом '\n' (в RichTextBox конец строки — один символ '\n')
            int lineCount = text.Split('\n').Length;
            int currentLine = text.Substring(0, richTextBox.SelectionStart).Split('\n').Length;

            using (GoToForm dialog = new GoToForm(currentLine, lineCount))
            {
                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;
                int index = 0; // начало нужной строки = позиция после (N-1)-го '\n'
                for (int i = 1; i < dialog.LineNumber; i++)
                    index = text.IndexOf('\n', index) + 1;
                richTextBox.Select(index, 0);
                richTextBox.ScrollToCaret();
            }
        }

        // ===================== Формат =====================

        private void wordWrapItem_Click(object sender, EventArgs e)
        {
            richTextBox.WordWrap = wordWrapItem.Checked;
            // При переносе горизонтальная прокрутка не нужна
            richTextBox.ScrollBars = richTextBox.WordWrap ? RichTextBoxScrollBars.Vertical : RichTextBoxScrollBars.Both;
        }

        private void fontItem_Click(object sender, EventArgs e)
        {
            // SelectionFont == null, если в выделении несколько разных шрифтов
            fontDialog1.Font = richTextBox.SelectionFont ?? richTextBox.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox.SelectionFont = fontDialog1.Font; // шрифт только выделенного фрагмента
        }

        // Галочка стоит у выравнивания абзаца, в котором находится курсор
        private void alignMenu_DropDownOpening(object sender, EventArgs e)
        {
            HorizontalAlignment alignment = richTextBox.SelectionAlignment;
            alignLeftItem.Checked = alignment == HorizontalAlignment.Left;
            alignCenterItem.Checked = alignment == HorizontalAlignment.Center;
            alignRightItem.Checked = alignment == HorizontalAlignment.Right;
        }

        // Выравнивание задаётся абзацам, которые попали в выделение (или абзацу с курсором)
        private void alignLeftItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignCenterItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alignRightItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        // ===================== Справка =====================

        private void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор\nЛабораторная работа №2", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
