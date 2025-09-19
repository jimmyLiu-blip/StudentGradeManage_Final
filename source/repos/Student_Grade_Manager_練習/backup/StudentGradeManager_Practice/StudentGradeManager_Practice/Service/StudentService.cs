using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentGradeManager_Practice.Repository;
using StudentGradeManager_Practice.Domain;


namespace StudentGradeManager_Practice.Service
{
    public class StudentService
    {
        private readonly FileRepository _fileRepository;
        private List<Student> _students;

        public StudentService(FileRepository fileRepository)
        {
            _fileRepository = fileRepository;
            _students = _fileRepository.LoadDataToJson();
        }

        // 1. 新增學生
        public void AddStudent(string numberId, string name, string className)
        {
            if (_students.Any(s => s.NumberId == numberId))
            {
                throw new InvalidOperationException("此學生的學號已存在");
            }
            _students.Add(new Student(numberId, name, className));
            // 存檔不確定有沒有寫對
            _fileRepository.SaveDataToJson(_students);
        }

        // 2. 取得所有學生

        //  public List<Student> GetAllStudent()
        //  {
        //    return List<Students>(_students); 新增_students的副本不確定怎麼寫 
        //  }
        public List<Student> GetAllStudent()
        {
            return _students;
        }

        // 3.為指定學生新增成績
        //public List<Grade> AddGrade(string numberId, string subject, double score)
        public void AddGrade(string numberId, string subject, double score)
        {
            var student = _students.FirstOrDefault(s => s.NumberId == numberId);
            if (student == null)
            {
                throw new InvalidOperationException("找不到指定的學生");
            }
            student.Grades.Add(new Grade(subject, score)); //不確定有沒有寫對
            _fileRepository.SaveDataToJson(_students);    //不確定存檔中要寫什麼
        }

        // 4.查詢某位學生的所有成績
        public List<Grade> GetStudentGrades(string numberId)
        {
            var student = _students.FirstOrDefault(s => s.NumberId == numberId);
            return student?.Grades ?? new List<Grade>();
        }

        // 5.使用LINQ成績分析
        public (double average, double highest, double lowest) GetStudentStatistic(string numberId)
        {
            var student = _students.FirstOrDefault(s => s.NumberId == numberId);
            if (student == null || student.Grades == new List<Grade>())
            {
                return (0, 0, 0);
            }
            //double average = _students.Average(s => s.score); //忘記怎麼寫
            //double highest = _students.Max(s => s.score); //忘記怎麼寫
            //double lowest = _students.Min(s => s.score); //忘記怎麼寫
            double average = student.Grades.Average(g => g.Score);
            double highest = student.Grades.Max(g => g.Score);
            double lowest = student.Grades.Min(g => g.Score);

            return (average, highest, lowest);
        }

        // 查詢全班前3名

        public List<Student> Get3Top()
        {
            return _students
                //.Where(s => s.Grades != null) //忘記怎麼寫
                .Where(s => s.Grades.Any())
                //.OrderByDescending(s=>s.average(g=>g.score)) //忘記怎麼寫
                .OrderByDescending(s => s.Grades.Average(g => g.Score))
                .Take(3)
                .ToList();
        }
    }
}
