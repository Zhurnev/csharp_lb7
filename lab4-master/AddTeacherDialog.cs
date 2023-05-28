using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4
{
    public partial class AddTeacherDialog : Form
    {

        public string TeacherChosenName { get; set; }
        public int TeacherChosenId { get; set; }
        public AddTeacherDialog()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string teacherName = TeacherNameTextBox.Text;
            string teacherIdText = TeacherIdTextBox.Text;
            int teacherId;

            // Validate the teacher name
            if (string.IsNullOrWhiteSpace(teacherName))
            {
                MessageBox.Show("Please enter a valid teacher name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate the teacher ID
            if (string.IsNullOrWhiteSpace(teacherIdText) || !int.TryParse(teacherIdText, out teacherId))
            {
                MessageBox.Show("Please enter a valid teacher ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Both inputs are valid, set the properties and close the dialog
            TeacherChosenName = teacherName;
            TeacherChosenId = teacherId;
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
