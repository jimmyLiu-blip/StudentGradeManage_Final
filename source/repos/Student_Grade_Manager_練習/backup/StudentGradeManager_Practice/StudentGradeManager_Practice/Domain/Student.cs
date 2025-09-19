using System.Collections.Generic;

namespace StudentGradeManager_Practice.Domain
{
    public class Student
    { 
        public string NumberId {  get; set; }
        public string Name { get; set; }
        public string ClassName {  get; set; }
        public List<Grade> Grades { get; set; } = new List<Grade>();

        public Student(string numberId, string name, string className)
        {
            NumberId = numberId;
            Name = name;
            ClassName = className;
        }
    }
}
