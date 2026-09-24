using System;
using System.Windows.Forms;

namespace text_editor_windows_forms_misha
{
    // Одна форма на два режима: «Найти» и «Заменить»
    public partial class FindForm : Form
    {
        private readonly Form1 editor; // главное окно, в котором выполняется поиск

        public FindForm(Form1 editor, bool replaceMode, string what)
        {
            InitializeComponent();
            this.editor = editor;
            textWhat.Text = what;

            if (!replaceMode)
            {
                // Режим «Найти»: прячем всё, что относится к замене, и поднимаем остальное
                Text = "Найти";
                labelWith.Visible = false;
                textWith.Visible = false;
                buttonReplace.Visible = false;
                buttonReplaceAll.Visible = false;
                groupDirection.Top = textWith.Top;
                buttonCancel.Top = buttonReplace.Top;
                ClientSize = new System.Drawing.Size(ClientSize.Width, 95);
            }
            UpdateButtons();
        }

        // Пока поле «Что:» пустое, искать нечего — кнопки недоступны
        private void UpdateButtons()
        {
            bool hasText = textWhat.Text != "";
            buttonFindNext.Enabled = hasText;
            buttonReplace.Enabled = hasText;
            buttonReplaceAll.Enabled = hasText;
        }

        private void textWhat_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void buttonFindNext_Click(object sender, EventArgs e)
        {
            editor.FindText(textWhat.Text, radioDown.Checked);
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            editor.ReplaceText(textWhat.Text, textWith.Text, radioDown.Checked);
        }

        private void buttonReplaceAll_Click(object sender, EventArgs e)
        {
            editor.ReplaceAll(textWhat.Text, textWith.Text);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
