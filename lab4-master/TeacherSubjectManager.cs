using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lab4
{
    public class TeacherSubjectManager
    {
        private string connectionString;
        private List<Teacher> teachers;
        private List<Subject> subjects;
        public TeacherSubjectManager(string connectionString)
        {
            this.connectionString = connectionString;
            teachers = new List<Teacher>();
            subjects = new List<Subject>();
        }
        public void AddTeacher(Teacher teacher)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                if (TeacherExists(teacher.Id))
                {
                    MessageBox.Show("A teacher with the same ID already exists.", "Duplicate Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query = "INSERT INTO Teachers (Id, Name) VALUES (@Id, @Name)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", teacher.Id);
                    command.Parameters.AddWithValue("@Name", teacher.Name);
                    command.ExecuteNonQuery();
                }
            }
        }
        private bool TeacherExists(int teacherId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Teachers WHERE Id = @Id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", teacherId);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public void RemoveTeacher(Teacher teacher)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string deleteTeacherSubjectsQuery = "DELETE FROM TeacherSubjects WHERE TeacherId = @Id";
                using (var deleteTeacherSubjectsCommand = new MySqlCommand(deleteTeacherSubjectsQuery, connection))
                {
                    deleteTeacherSubjectsCommand.Parameters.AddWithValue("@Id", teacher.Id);
                    deleteTeacherSubjectsCommand.ExecuteNonQuery();
                }
                string deleteTeacherQuery = "DELETE FROM Teachers WHERE Id = @Id";
                using (var deleteTeacherCommand = new MySqlCommand(deleteTeacherQuery, connection))
                {
                    deleteTeacherCommand.Parameters.AddWithValue("@Id", teacher.Id);
                    deleteTeacherCommand.ExecuteNonQuery();
                }
            }
        }
        public List<Teacher> GetAllTeachers()
        {
            teachers.Clear();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Teachers";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("Id"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            var teacher = new Teacher(id, name);
                            teachers.Add(teacher);
                        }
                    }
                }
            }
            return teachers;
        }
        public void AddSubject(Subject subject)
        {
            if (SubjectIdExists(subject.Id))
            {
                MessageBox.Show("A subject with the same ID already exists.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Subjects (Id, Name) VALUES (@Id, @Name)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", subject.Id);
                    command.Parameters.AddWithValue("@Name", subject.Name);
                    command.ExecuteNonQuery();
                }
            }
        }
        private bool SubjectIdExists(int subjectId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Subjects WHERE Id = @Id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", subjectId);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public void RemoveSubject(Subject subject)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string deleteTeacherSubjectsQuery = "DELETE FROM TeacherSubjects WHERE SubjectId = @Id";
                using (var deleteTeacherSubjectsCommand = new MySqlCommand(deleteTeacherSubjectsQuery, connection))
                {
                    deleteTeacherSubjectsCommand.Parameters.AddWithValue("@Id", subject.Id);
                    deleteTeacherSubjectsCommand.ExecuteNonQuery();
                }
                string deleteSubjectQuery = "DELETE FROM Subjects WHERE Id = @Id";
                using (var deleteSubjectCommand = new MySqlCommand(deleteSubjectQuery, connection))
                {
                    deleteSubjectCommand.Parameters.AddWithValue("@Id", subject.Id);
                    deleteSubjectCommand.ExecuteNonQuery();
                }
            }
        }
        public List<Subject> GetAllSubjects()
        {
            subjects.Clear();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Subjects";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("Id"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            var subject = new Subject(id, name);
                            subjects.Add(subject);
                        }
                    }
                }
            }
            return subjects;
        }
        public void AssignTeacherToSubject(Teacher teacher, Subject subject)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM TeacherSubjects WHERE TeacherId = @TeacherId AND SubjectId = @SubjectId";
                using (var checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@TeacherId", teacher.Id);
                    checkCommand.Parameters.AddWithValue("@SubjectId", subject.Id);
                    int existingConnectionCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                    if (existingConnectionCount > 0)
                    {
                        Console.WriteLine("The teacher-subject connection already exists.");
                        return;
                    }
                }
                string insertQuery = "INSERT INTO TeacherSubjects (TeacherId, SubjectId) VALUES (@TeacherId, @SubjectId)";
                using (var insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@TeacherId", teacher.Id);
                    insertCommand.Parameters.AddWithValue("@SubjectId", subject.Id);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
        public void RemoveConnection(Teacher teacher, Subject subject)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM TeacherSubjects WHERE TeacherId = @TeacherId AND SubjectId = @SubjectId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeacherId", teacher.Id);
                    command.Parameters.AddWithValue("@SubjectId", subject.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void SortTeachersByName()
        {
            var teachers = GetAllTeachers();
            teachers = teachers.OrderBy(t => t.Name).ToList();
            this.teachers.Clear();
            this.teachers.AddRange(teachers);
        }
        public List<string> GetSubjectNamesByTeacherId(int teacherId)
        {
            List<string> subjectNames = new List<string>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT subjects.Name FROM TeacherSubjects " +
                               "JOIN Subjects ON TeacherSubjects.SubjectId = Subjects.Id " +
                               "WHERE TeacherSubjects.TeacherId = @TeacherId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeacherId", teacherId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string subjectName = reader.GetString("Name");
                            subjectNames.Add(subjectName);
                        }
                    }
                }
            }
            return subjectNames;
        }
        public Teacher GetTeacherById(int teacherId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Teachers WHERE ID = @TeacherId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeacherId", teacherId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32("ID");
                            string name = reader.GetString("Name");
                            return new Teacher(id, name);
                        }
                    }
                }
            }
            return null;
        }
    }
}
