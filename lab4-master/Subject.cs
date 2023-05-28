using System;
using System.Collections.Generic;

namespace lab4
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<String> TeacherNames { get; set; }
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
            TeacherNames = new List<String>();
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}