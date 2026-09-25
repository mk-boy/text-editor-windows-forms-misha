namespace text_editor_windows_forms_misha
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.findItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPrevItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.alignLeftItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignCenterItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignRightItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.formatMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // fileMenu
            //
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItem,
            this.newWindowItem,
            this.openItem,
            this.saveItem,
            this.saveAsItem,
            this.fileSeparator,
            this.exitItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 20);
            this.fileMenu.Text = "Файл";
            //
            // newItem
            //
            this.newItem.Name = "newItem";
            this.newItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newItem.Size = new System.Drawing.Size(250, 22);
            this.newItem.Text = "Создать";
            this.newItem.Click += new System.EventHandler(this.newItem_Click);
            //
            // newWindowItem
            //
            this.newWindowItem.Name = "newWindowItem";
            this.newWindowItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.N)));
            this.newWindowItem.Size = new System.Drawing.Size(250, 22);
            this.newWindowItem.Text = "Новое окно";
            this.newWindowItem.Click += new System.EventHandler(this.newWindowItem_Click);
            //
            // openItem
            //
            this.openItem.Name = "openItem";
            this.openItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openItem.Size = new System.Drawing.Size(250, 22);
            this.openItem.Text = "Открыть...";
            this.openItem.Click += new System.EventHandler(this.openItem_Click);
            //
            // saveItem
            //
            this.saveItem.Name = "saveItem";
            this.saveItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveItem.Size = new System.Drawing.Size(250, 22);
            this.saveItem.Text = "Сохранить";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            //
            // saveAsItem
            //
            this.saveAsItem.Name = "saveAsItem";
            this.saveAsItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.S)));
            this.saveAsItem.Size = new System.Drawing.Size(250, 22);
            this.saveAsItem.Text = "Сохранить как...";
            this.saveAsItem.Click += new System.EventHandler(this.saveAsItem_Click);
            //
            // fileSeparator
            //
            this.fileSeparator.Name = "fileSeparator";
            this.fileSeparator.Size = new System.Drawing.Size(247, 6);
            //
            // exitItem
            //
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(250, 22);
            this.exitItem.Text = "Выход";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            //
            // editMenu
            //
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoItem,
            this.editSeparator1,
            this.cutItem,
            this.copyItem,
            this.pasteItem,
            this.deleteItem,
            this.editSeparator2,
            this.findItem,
            this.findNextItem,
            this.findPrevItem,
            this.replaceItem,
            this.goToItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(59, 20);
            this.editMenu.Text = "Правка";
            this.editMenu.DropDownOpening += new System.EventHandler(this.editMenu_DropDownOpening);
            //
            // undoItem
            //
            this.undoItem.Name = "undoItem";
            this.undoItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoItem.Size = new System.Drawing.Size(220, 22);
            this.undoItem.Text = "Отменить";
            this.undoItem.Click += new System.EventHandler(this.undoItem_Click);
            //
            // editSeparator1
            //
            this.editSeparator1.Name = "editSeparator1";
            this.editSeparator1.Size = new System.Drawing.Size(217, 6);
            //
            // cutItem
            //
            this.cutItem.Name = "cutItem";
            this.cutItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutItem.Size = new System.Drawing.Size(220, 22);
            this.cutItem.Text = "Вырезать";
            this.cutItem.Click += new System.EventHandler(this.cutItem_Click);
            //
            // copyItem
            //
            this.copyItem.Name = "copyItem";
            this.copyItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyItem.Size = new System.Drawing.Size(220, 22);
            this.copyItem.Text = "Копировать";
            this.copyItem.Click += new System.EventHandler(this.copyItem_Click);
            //
            // pasteItem
            //
            this.pasteItem.Name = "pasteItem";
            this.pasteItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteItem.Size = new System.Drawing.Size(220, 22);
            this.pasteItem.Text = "Вставить";
            this.pasteItem.Click += new System.EventHandler(this.pasteItem_Click);
            //
            // deleteItem
            //
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.ShortcutKeyDisplayString = "Del";
            this.deleteItem.Size = new System.Drawing.Size(220, 22);
            this.deleteItem.Text = "Удалить";
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            //
            // editSeparator2
            //
            this.editSeparator2.Name = "editSeparator2";
            this.editSeparator2.Size = new System.Drawing.Size(217, 6);
            //
            // findItem
            //
            this.findItem.Name = "findItem";
            this.findItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findItem.Size = new System.Drawing.Size(220, 22);
            this.findItem.Text = "Найти...";
            this.findItem.Click += new System.EventHandler(this.findItem_Click);
            //
            // findNextItem
            //
            this.findNextItem.Name = "findNextItem";
            this.findNextItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findNextItem.Size = new System.Drawing.Size(220, 22);
            this.findNextItem.Text = "Найти далее";
            this.findNextItem.Click += new System.EventHandler(this.findNextItem_Click);
            //
            // findPrevItem
            //
            this.findPrevItem.Name = "findPrevItem";
            this.findPrevItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.findPrevItem.Size = new System.Drawing.Size(220, 22);
            this.findPrevItem.Text = "Найти ранее";
            this.findPrevItem.Click += new System.EventHandler(this.findPrevItem_Click);
            //
            // replaceItem
            //
            this.replaceItem.Name = "replaceItem";
            this.replaceItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceItem.Size = new System.Drawing.Size(220, 22);
            this.replaceItem.Text = "Заменить...";
            this.replaceItem.Click += new System.EventHandler(this.replaceItem_Click);
            //
            // goToItem
            //
            this.goToItem.Name = "goToItem";
            this.goToItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goToItem.Size = new System.Drawing.Size(220, 22);
            this.goToItem.Text = "Перейти...";
            this.goToItem.Click += new System.EventHandler(this.goToItem_Click);
            //
            // formatMenu
            //
            this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapItem,
            this.fontItem,
            this.alignMenu});
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(62, 20);
            this.formatMenu.Text = "Формат";
            //
            // wordWrapItem
            //
            this.wordWrapItem.CheckOnClick = true;
            this.wordWrapItem.Name = "wordWrapItem";
            this.wordWrapItem.Size = new System.Drawing.Size(180, 22);
            this.wordWrapItem.Text = "Перенос по словам";
            this.wordWrapItem.Click += new System.EventHandler(this.wordWrapItem_Click);
            //
            // fontItem
            //
            this.fontItem.Name = "fontItem";
            this.fontItem.Size = new System.Drawing.Size(180, 22);
            this.fontItem.Text = "Шрифт...";
            this.fontItem.Click += new System.EventHandler(this.fontItem_Click);
            //
            // alignMenu
            //
            this.alignMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alignLeftItem,
            this.alignCenterItem,
            this.alignRightItem});
            this.alignMenu.Name = "alignMenu";
            this.alignMenu.Size = new System.Drawing.Size(180, 22);
            this.alignMenu.Text = "Выравнивание";
            this.alignMenu.DropDownOpening += new System.EventHandler(this.alignMenu_DropDownOpening);
            //
            // alignLeftItem
            //
            this.alignLeftItem.Checked = true;
            this.alignLeftItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alignLeftItem.Name = "alignLeftItem";
            this.alignLeftItem.Size = new System.Drawing.Size(180, 22);
            this.alignLeftItem.Text = "По левому краю";
            this.alignLeftItem.Click += new System.EventHandler(this.alignLeftItem_Click);
            //
            // alignCenterItem
            //
            this.alignCenterItem.Name = "alignCenterItem";
            this.alignCenterItem.Size = new System.Drawing.Size(180, 22);
            this.alignCenterItem.Text = "По центру";
            this.alignCenterItem.Click += new System.EventHandler(this.alignCenterItem_Click);
            //
            // alignRightItem
            //
            this.alignRightItem.Name = "alignRightItem";
            this.alignRightItem.Size = new System.Drawing.Size(180, 22);
            this.alignRightItem.Text = "По правому краю";
            this.alignRightItem.Click += new System.EventHandler(this.alignRightItem_Click);
            //
            // helpMenu
            //
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(65, 20);
            this.helpMenu.Text = "Справка";
            //
            // aboutItem
            //
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(180, 22);
            this.aboutItem.Text = "О программе";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            //
            // richTextBox
            //
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Consolas", 11F);
            this.richTextBox.HideSelection = false;
            this.richTextBox.Location = new System.Drawing.Point(0, 24);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 426);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            this.richTextBox.WordWrap = false;
            //
            // openFileDialog1
            //
            this.openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Документы RTF (*.rtf)|*.rtf|Все файлы (*.*)|*.*";
            //
            // saveFileDialog1
            //
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Документы RTF (*.rtf)|*.rtf|Все файлы (*.*)|*.*";
            //
            // fontDialog1
            //
            this.fontDialog1.ShowEffects = false;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowItem;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsItem;
        private System.Windows.Forms.ToolStripSeparator fileSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoItem;
        private System.Windows.Forms.ToolStripSeparator editSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutItem;
        private System.Windows.Forms.ToolStripMenuItem copyItem;
        private System.Windows.Forms.ToolStripMenuItem pasteItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItem;
        private System.Windows.Forms.ToolStripSeparator editSeparator2;
        private System.Windows.Forms.ToolStripMenuItem findItem;
        private System.Windows.Forms.ToolStripMenuItem findNextItem;
        private System.Windows.Forms.ToolStripMenuItem findPrevItem;
        private System.Windows.Forms.ToolStripMenuItem replaceItem;
        private System.Windows.Forms.ToolStripMenuItem goToItem;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStripMenuItem wordWrapItem;
        private System.Windows.Forms.ToolStripMenuItem fontItem;
        private System.Windows.Forms.ToolStripMenuItem alignMenu;
        private System.Windows.Forms.ToolStripMenuItem alignLeftItem;
        private System.Windows.Forms.ToolStripMenuItem alignCenterItem;
        private System.Windows.Forms.ToolStripMenuItem alignRightItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

