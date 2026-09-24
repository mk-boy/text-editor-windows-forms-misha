using System.Windows.Forms;

namespace text_editor_windows_forms_misha
{
    // Диалог «Перейти к строке»
    public partial class GoToForm : Form
    {
        public GoToForm(int currentLine, int lineCount)
        {
            InitializeComponent();
            numericLine.Maximum = lineCount; // больше строк, чем есть в тексте, ввести нельзя
            numericLine.Value = currentLine;
        }

        // Номер строки, выбранный пользователем (начиная с 1)
        public int LineNumber
        {
            get { return (int)numericLine.Value; }
        }
    }
}
