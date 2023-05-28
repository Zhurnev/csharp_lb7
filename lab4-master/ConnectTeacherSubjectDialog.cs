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
    public partial class SelectTeacherSubjectDialog : Form
    {
        public SelectTeacherSubjectDialog(List<Teacher> teachers, List<Subject> subjects)

        {
            InitializeComponent();
            teacherListBox.DataSource = teachers;
            subjectListBox.DataSource = subjects;
        }

        public Teacher selectedTeacher { get; private set; }
        public Subject selectedSubject { get; private set; }
        private void connectButton_Click(object sender, EventArgs e)
        {
             selectedTeacher = (Teacher)teacherListBox.SelectedItem;
             selectedSubject = (Subject)subjectListBox.SelectedItem;
            this.Close();
        }
    }
}
