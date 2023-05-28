namespace lab4
{
    partial class SelectTeacherSubjectDialog
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
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.subjectListBox = new System.Windows.Forms.ListBox();
            this.proceedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacherListBox
            // 
            this.teacherListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.ItemHeight = 20;
            this.teacherListBox.Location = new System.Drawing.Point(0, 1);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.Size = new System.Drawing.Size(149, 224);
            this.teacherListBox.TabIndex = 0;
            // 
            // subjectListBox
            // 
            this.subjectListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectListBox.FormattingEnabled = true;
            this.subjectListBox.ItemHeight = 20;
            this.subjectListBox.Location = new System.Drawing.Point(155, 1);
            this.subjectListBox.Name = "subjectListBox";
            this.subjectListBox.Size = new System.Drawing.Size(149, 224);
            this.subjectListBox.TabIndex = 1;
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proceedButton.Location = new System.Drawing.Point(327, 93);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(96, 35);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // SelectTeacherSubjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 240);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.subjectListBox);
            this.Controls.Add(this.teacherListBox);
            this.Name = "SelectTeacherSubjectDialog";
            this.Text = "SelectTeacherSubjectDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teacherListBox;
        private System.Windows.Forms.ListBox subjectListBox;
        private System.Windows.Forms.Button proceedButton;
    }
}