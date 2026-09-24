namespace text_editor_windows_forms_misha
{
    partial class GoToForm
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
            this.labelLine = new System.Windows.Forms.Label();
            this.numericLine = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericLine)).BeginInit();
            this.SuspendLayout();
            //
            // labelLine
            //
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(12, 12);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(80, 13);
            this.labelLine.TabIndex = 0;
            this.labelLine.Text = "Номер строки:";
            //
            // numericLine
            //
            this.numericLine.Location = new System.Drawing.Point(15, 30);
            this.numericLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLine.Name = "numericLine";
            this.numericLine.Size = new System.Drawing.Size(230, 20);
            this.numericLine.TabIndex = 1;
            this.numericLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // buttonOk
            //
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(89, 62);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 25);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Перейти";
            this.buttonOk.UseVisualStyleBackColor = true;
            //
            // buttonCancel
            //
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(170, 62);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            //
            // GoToForm
            //
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(260, 99);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.numericLine);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Переход на строку";
            ((System.ComponentModel.ISupportInitialize)(this.numericLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.NumericUpDown numericLine;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
