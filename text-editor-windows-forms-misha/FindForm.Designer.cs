namespace text_editor_windows_forms_misha
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWhat = new System.Windows.Forms.Label();
            this.textWhat = new System.Windows.Forms.TextBox();
            this.labelWith = new System.Windows.Forms.Label();
            this.textWith = new System.Windows.Forms.TextBox();
            this.groupDirection = new System.Windows.Forms.GroupBox();
            this.radioUp = new System.Windows.Forms.RadioButton();
            this.radioDown = new System.Windows.Forms.RadioButton();
            this.buttonFindNext = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonReplaceAll = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupDirection.SuspendLayout();
            this.SuspendLayout();
            //
            // labelWhat
            //
            this.labelWhat.AutoSize = true;
            this.labelWhat.Location = new System.Drawing.Point(12, 15);
            this.labelWhat.Name = "labelWhat";
            this.labelWhat.Size = new System.Drawing.Size(30, 13);
            this.labelWhat.TabIndex = 0;
            this.labelWhat.Text = "Что:";
            //
            // textWhat
            //
            this.textWhat.Location = new System.Drawing.Point(95, 12);
            this.textWhat.Name = "textWhat";
            this.textWhat.Size = new System.Drawing.Size(200, 20);
            this.textWhat.TabIndex = 1;
            this.textWhat.TextChanged += new System.EventHandler(this.textWhat_TextChanged);
            //
            // labelWith
            //
            this.labelWith.AutoSize = true;
            this.labelWith.Location = new System.Drawing.Point(12, 44);
            this.labelWith.Name = "labelWith";
            this.labelWith.Size = new System.Drawing.Size(74, 13);
            this.labelWith.TabIndex = 2;
            this.labelWith.Text = "Заменить на:";
            //
            // textWith
            //
            this.textWith.Location = new System.Drawing.Point(95, 41);
            this.textWith.Name = "textWith";
            this.textWith.Size = new System.Drawing.Size(200, 20);
            this.textWith.TabIndex = 3;
            //
            // groupDirection
            //
            this.groupDirection.Controls.Add(this.radioUp);
            this.groupDirection.Controls.Add(this.radioDown);
            this.groupDirection.Location = new System.Drawing.Point(95, 70);
            this.groupDirection.Name = "groupDirection";
            this.groupDirection.Size = new System.Drawing.Size(200, 45);
            this.groupDirection.TabIndex = 4;
            this.groupDirection.TabStop = false;
            this.groupDirection.Text = "Направление";
            //
            // radioUp
            //
            this.radioUp.AutoSize = true;
            this.radioUp.Location = new System.Drawing.Point(15, 18);
            this.radioUp.Name = "radioUp";
            this.radioUp.Size = new System.Drawing.Size(56, 17);
            this.radioUp.TabIndex = 0;
            this.radioUp.Text = "Вверх";
            this.radioUp.UseVisualStyleBackColor = true;
            //
            // radioDown
            //
            this.radioDown.AutoSize = true;
            this.radioDown.Checked = true;
            this.radioDown.Location = new System.Drawing.Point(100, 18);
            this.radioDown.Name = "radioDown";
            this.radioDown.Size = new System.Drawing.Size(51, 17);
            this.radioDown.TabIndex = 1;
            this.radioDown.TabStop = true;
            this.radioDown.Text = "Вниз";
            this.radioDown.UseVisualStyleBackColor = true;
            //
            // buttonFindNext
            //
            this.buttonFindNext.Location = new System.Drawing.Point(310, 10);
            this.buttonFindNext.Name = "buttonFindNext";
            this.buttonFindNext.Size = new System.Drawing.Size(100, 25);
            this.buttonFindNext.TabIndex = 5;
            this.buttonFindNext.Text = "Найти далее";
            this.buttonFindNext.UseVisualStyleBackColor = true;
            this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNext_Click);
            //
            // buttonReplace
            //
            this.buttonReplace.Location = new System.Drawing.Point(310, 39);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(100, 25);
            this.buttonReplace.TabIndex = 6;
            this.buttonReplace.Text = "Заменить";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            //
            // buttonReplaceAll
            //
            this.buttonReplaceAll.Location = new System.Drawing.Point(310, 68);
            this.buttonReplaceAll.Name = "buttonReplaceAll";
            this.buttonReplaceAll.Size = new System.Drawing.Size(100, 25);
            this.buttonReplaceAll.TabIndex = 7;
            this.buttonReplaceAll.Text = "Заменить все";
            this.buttonReplaceAll.UseVisualStyleBackColor = true;
            this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
            //
            // buttonCancel
            //
            this.buttonCancel.Location = new System.Drawing.Point(310, 97);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 25);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            //
            // FindForm
            //
            this.AcceptButton = this.buttonFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(422, 130);
            this.Controls.Add(this.labelWhat);
            this.Controls.Add(this.textWhat);
            this.Controls.Add(this.labelWith);
            this.Controls.Add(this.textWith);
            this.Controls.Add(this.groupDirection);
            this.Controls.Add(this.buttonFindNext);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonReplaceAll);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заменить";
            this.groupDirection.ResumeLayout(false);
            this.groupDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWhat;
        private System.Windows.Forms.TextBox textWhat;
        private System.Windows.Forms.Label labelWith;
        private System.Windows.Forms.TextBox textWith;
        private System.Windows.Forms.GroupBox groupDirection;
        private System.Windows.Forms.RadioButton radioUp;
        private System.Windows.Forms.RadioButton radioDown;
        private System.Windows.Forms.Button buttonFindNext;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonReplaceAll;
        private System.Windows.Forms.Button buttonCancel;
    }
}
