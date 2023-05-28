using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class AddSubjectDialog : Form
    {
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
        public AddSubjectDialog()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string subjectName = subjectNameTextBox.Text;
            string subjectIdText = subjectIdTextBox.Text;
            int subjectId;

            // Validate the subject name
            if (string.IsNullOrWhiteSpace(subjectName))
            {
                MessageBox.Show("Please enter a valid subject name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate the subject ID
            if (string.IsNullOrWhiteSpace(subjectIdText) || !int.TryParse(subjectIdText, out subjectId))
            {
                MessageBox.Show("Please enter a valid subject ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Both inputs are valid, set the properties and close the dialog
            SubjectName = subjectName;
            SubjectId = subjectId;
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
