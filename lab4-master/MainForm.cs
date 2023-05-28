using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace lab4
{
    public partial class MainForm : Form
    {
        private TeacherSubjectManager manager;
        public MainForm(TeacherSubjectManager manager)
        {
            this.manager = manager;
            InitializeComponent();
            BindingList<Teacher> teacherList = new BindingList<Teacher>(this.manager.GetAllTeachers());

            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.DataPropertyName = "Id";
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn subjectsColumn = new DataGridViewTextBoxColumn();
            subjectsColumn.Name = "Subjects";
            subjectsColumn.DataPropertyName = "FormattedSubjectNames";
            subjectsColumn.DefaultCellStyle.NullValue = "None";
            subjectsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(subjectsColumn);

            dataGridView1.DataSource = teacherList;
        }
        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            var dialog = new AddTeacherDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var teacherName = dialog.TeacherChosenName;
                var teacherId = dialog.TeacherChosenId;
                var newTeacher = new Teacher(teacherId, teacherName);
                manager.AddTeacher(newTeacher);
                UpdateDataGridView();
            }
        }
        private void UpdateDataGridView()
        {
            dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.DataPropertyName = "Id";
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn subjectsColumn = new DataGridViewTextBoxColumn();
            subjectsColumn.Name = "Subjects";
            subjectsColumn.DataPropertyName = "FormattedSubjectNames";
            subjectsColumn.DefaultCellStyle.NullValue = "None";
            subjectsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add(subjectsColumn);

            var teachers = manager.GetAllTeachers();
            foreach (var teacher in teachers)
            {
                teacher.SubjectNames = manager.GetSubjectNamesByTeacherId(teacher.Id);
            }
            dataGridView1.DataSource = new BindingList<Teacher>(teachers);
        }
        private void removeTeacherButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to remove.");
                return;
            }
            var selectedRow = dataGridView1.SelectedRows[0];
            var teacherId = (int)selectedRow.Cells["ID"].Value;
            var selectedTeacher = manager.GetTeacherById(teacherId);
            if (selectedTeacher == null)
            {
                MessageBox.Show("Please select a valid teacher to remove.");
                return;
            }
            var dialog = new RemoveTeacherDialog(selectedTeacher.Name);
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                manager.RemoveTeacher(selectedTeacher);
                UpdateDataGridView();
            }
        }
        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            var dialog = new AddSubjectDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var subjectName = dialog.SubjectName;
                var subjectId = dialog.SubjectId;
                var newSubject = new Subject(subjectId, subjectName);
                this.manager.AddSubject(newSubject);
                UpdateDataGridView();
            }
        }
        private void removeSubjectButton_Click(object sender, EventArgs e)
        {
            var dialog = new RemoveSubjectDialog(this.manager.GetAllSubjects());
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var selectedSubject = dialog.SelectedSubject;
                this.manager.RemoveSubject(selectedSubject);
                UpdateDataGridView();
            }
        }
        private void connectTeacherSubjectButton_Click(object sender, EventArgs e)
        {
            var dialog = new SelectTeacherSubjectDialog(manager.GetAllTeachers(), manager.GetAllSubjects());
            dialog.ShowDialog();
            this.manager.AssignTeacherToSubject(dialog.selectedTeacher, dialog.selectedSubject);
            UpdateDataGridView();
        }
        private void removeConnectionButton_Click(object sender, EventArgs e)
        {
            var dialog = new SelectTeacherSubjectDialog(manager.GetAllTeachers(), manager.GetAllSubjects());
            dialog.ShowDialog();
            this.manager.RemoveConnection(dialog.selectedTeacher, dialog.selectedSubject);
            UpdateDataGridView();
        }
        private void sortNameButton_Click(object sender, EventArgs e)
        {
            manager.SortTeachersByName();
            UpdateDataGridView();
        }
       
    }
}
