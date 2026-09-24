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
            if (!textBox.Modified)
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

        private bool WriteFile(string path)
        {
            try
            {
                File.WriteAllText(path, textBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            fileName = path;
            textBox.Modified = false;
            UpdateTitle();
            return true;
        }

        private void newItem_Click(object sender, EventArgs e)
        {
            if (!ConfirmSave())
                return;
            textBox.Clear();
            textBox.Modified = false;
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
                textBox.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox.Modified = false;
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
            bool hasSelection = textBox.SelectionLength > 0;
            undoItem.Enabled = textBox.CanUndo;
            cutItem.Enabled = hasSelection;
            copyItem.Enabled = hasSelection;
            deleteItem.Enabled = hasSelection;
            pasteItem.Enabled = Clipboard.ContainsText();
        }

        private void undoItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void cutItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            textBox.Paste(""); // заменить выделение пустой строкой (с возможностью отмены)
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
            string text = textBox.Text;
            int index;
            if (down)
                index = text.IndexOf(what, textBox.SelectionStart + textBox.SelectionLength, StringComparison.Ordinal);
            else
                index = text.Substring(0, textBox.SelectionStart).LastIndexOf(what, StringComparison.Ordinal);

            if (index < 0)
            {
                MessageBox.Show("Не удается найти \"" + what + "\"", "Текстовый редактор",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            textBox.Select(index, what.Length);
            textBox.ScrollToCaret();
            return true;
        }

        // Заменяет текущее выделение (если это искомая строка) и ищет следующее вхождение.
        public void ReplaceText(string what, string with, bool down)
        {
            if (textBox.SelectedText == what)
                textBox.Paste(with);
            FindText(what, down);
        }

        public void ReplaceAll(string what, string with)
        {
            lastSearch = what;
            if (!textBox.Text.Contains(what))
            {
                MessageBox.Show("Не удается найти \"" + what + "\"", "Текстовый редактор",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string newText = textBox.Text.Replace(what, with);
            textBox.SelectAll();
            textBox.Paste(newText); // через Paste, чтобы замену можно было отменить Ctrl+Z
        }

        private void goToItem_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            // Строки разделяются символом '\n' (Enter в TextBox вставляет "\r\n")
            int lineCount = text.Split('\n').Length;
            int currentLine = text.Substring(0, textBox.SelectionStart).Split('\n').Length;

            using (GoToForm dialog = new GoToForm(currentLine, lineCount))
            {
                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;
                int index = 0; // начало нужной строки = позиция после (N-1)-го '\n'
                for (int i = 1; i < dialog.LineNumber; i++)
                    index = text.IndexOf('\n', index) + 1;
                textBox.Select(index, 0);
                textBox.ScrollToCaret();
            }
        }

        // ===================== Формат =====================

        private void wordWrapItem_Click(object sender, EventArgs e)
        {
            textBox.WordWrap = wordWrapItem.Checked;
            // При переносе горизонтальная прокрутка не нужна
            textBox.ScrollBars = textBox.WordWrap ? ScrollBars.Vertical : ScrollBars.Both;
        }

        private void fontItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox.Font = fontDialog1.Font;
        }

        private void SetAlignment(HorizontalAlignment alignment)
        {
            textBox.TextAlign = alignment;
            alignLeftItem.Checked = alignment == HorizontalAlignment.Left;
            alignCenterItem.Checked = alignment == HorizontalAlignment.Center;
            alignRightItem.Checked = alignment == HorizontalAlignment.Right;
        }

        private void alignLeftItem_Click(object sender, EventArgs e)
        {
            SetAlignment(HorizontalAlignment.Left);
        }

        private void alignCenterItem_Click(object sender, EventArgs e)
        {
            SetAlignment(HorizontalAlignment.Center);
        }

        private void alignRightItem_Click(object sender, EventArgs e)
        {
            SetAlignment(HorizontalAlignment.Right);
        }

        // ===================== Справка =====================

        private void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор\nЛабораторная работа №2", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
