using System.Collections.Generic;

namespace Student_Grade_Manager.Domain  
{
    public class Student
    {
        public string StudentId { get; set; } 
        public string Name { get; set; }
        public string ClassName {  get; set; }
        public List<Grade> Grades { get; set; } = new List<Grade>();

        public Student(string studentId, string name, string className)
        {
            StudentId = studentId;
            Name = name;
            ClassName = className;
        }
    }
}
