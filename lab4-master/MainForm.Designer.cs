namespace lab4
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.removeTeacherButton = new System.Windows.Forms.Button();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.removeSubjectButton = new System.Windows.Forms.Button();
            this.connectTeacherSubjectButton = new System.Windows.Forms.Button();
            this.removeConnectionButton = new System.Windows.Forms.Button();
            this.sortNameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "ID", HeaderText = "ID" },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Name", HeaderText = "Name" },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Subjects", HeaderText = "Subjects" }
            });
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeacherButton.Location = new System.Drawing.Point(646, 12);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(99, 33);
            this.addTeacherButton.TabIndex = 1;
            this.addTeacherButton.Text = "Add Teacher";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // removeTeacherButton
            // 
            this.removeTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeTeacherButton.Location = new System.Drawing.Point(646, 51);
            this.removeTeacherButton.Name = "removeTeacherButton";
            this.removeTeacherButton.Size = new System.Drawing.Size(125, 33);
            this.removeTeacherButton.TabIndex = 2;
            this.removeTeacherButton.Text = "Remove Teacher";
            this.removeTeacherButton.UseVisualStyleBackColor = true;
            this.removeTeacherButton.Click += new System.EventHandler(this.removeTeacherButton_Click);
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSubjectButton.Location = new System.Drawing.Point(646, 90);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(94, 33);
            this.AddSubjectButton.TabIndex = 3;
            this.AddSubjectButton.Text = "Add Subject";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // removeSubjectButton
            // 
            this.removeSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeSubjectButton.Location = new System.Drawing.Point(646, 129);
            this.removeSubjectButton.Name = "removeSubjectButton";
            this.removeSubjectButton.Size = new System.Drawing.Size(120, 33);
            this.removeSubjectButton.TabIndex = 4;
            this.removeSubjectButton.Text = "Remove Subject";
            this.removeSubjectButton.UseVisualStyleBackColor = true;
            this.removeSubjectButton.Click += new System.EventHandler(this.removeSubjectButton_Click);
            // 
            // connectTeacherSubjectButton
            // 
            this.connectTeacherSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectTeacherSubjectButton.Location = new System.Drawing.Point(776, 12);
            this.connectTeacherSubjectButton.Name = "connectTeacherSubjectButton";
            this.connectTeacherSubjectButton.Size = new System.Drawing.Size(133, 33);
            this.connectTeacherSubjectButton.TabIndex = 5;
            this.connectTeacherSubjectButton.Text = "Create Connection";
            this.connectTeacherSubjectButton.UseVisualStyleBackColor = true;
            this.connectTeacherSubjectButton.Click += new System.EventHandler(this.connectTeacherSubjectButton_Click);
            // 
            // removeConnectionButton
            // 
            this.removeConnectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeConnectionButton.Location = new System.Drawing.Point(777, 51);
            this.removeConnectionButton.Name = "removeConnectionButton";
            this.removeConnectionButton.Size = new System.Drawing.Size(144, 33);
            this.removeConnectionButton.TabIndex = 6;
            this.removeConnectionButton.Text = "Remove Connection";
            this.removeConnectionButton.UseVisualStyleBackColor = true;
            this.removeConnectionButton.Click += new System.EventHandler(this.removeConnectionButton_Click);
            // 
            // sortNameButton
            // 
            this.sortNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortNameButton.Location = new System.Drawing.Point(777, 90);
            this.sortNameButton.Name = "sortNameButton";
            this.sortNameButton.Size = new System.Drawing.Size(103, 33);
            this.sortNameButton.TabIndex = 7;
            this.sortNameButton.Text = "Sort by Name";
            this.sortNameButton.UseVisualStyleBackColor = true;
            this.sortNameButton.Click += new System.EventHandler(this.sortNameButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 182);
            this.Controls.Add(this.sortNameButton);
            this.Controls.Add(this.removeConnectionButton);
            this.Controls.Add(this.connectTeacherSubjectButton);
            this.Controls.Add(this.removeSubjectButton);
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.removeTeacherButton);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button removeTeacherButton;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.Button removeSubjectButton;
        private System.Windows.Forms.Button connectTeacherSubjectButton;
        private System.Windows.Forms.Button removeConnectionButton;
        private System.Windows.Forms.Button sortNameButton;
    }
}

