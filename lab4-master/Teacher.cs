using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> SubjectNames { get; set; }

        public Teacher(int id, string name)
        {
            Id = id;
            Name = name;
            SubjectNames = new List<string>();
        }

        public string FormattedSubjectNames
        {
            get { return string.Join(", ", SubjectNames); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
