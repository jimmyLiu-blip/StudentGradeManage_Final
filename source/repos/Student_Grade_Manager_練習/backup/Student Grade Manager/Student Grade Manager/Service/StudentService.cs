using Student_Grade_Manager.Domain;
using Student_Grade_Manager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Grade_Manager.Service
{
    public class StudentService
    {
        // _fileRepository 並不是代表整個 FileRepository 類別，它指向一個 FileRepository 物件，不是物件本身，是指向物件的變數
        // _fileRepository 變數能夠讓我在 StudentService 類別的程式碼中，使用並操作那個被傳進來的FileRepository 物件
        // _fileRepository.SaveDataToJson , _fileRepository.LoadDataFromJson
        private readonly FileRepository _fileRepository;
        private List<Student> _students;
        // _students 是一個變數
        // _students是指向List <Student> 的變數
        // 透過 _students 操作同一個列表 

        // 建構子，接收一個 FileRepository 實例 fileRepository
        // 建構子：建立 StudentService 物件時會執行
        // 建立物件 = 啟動整個流程
        public StudentService(FileRepository fileRepository)
        {
            _fileRepository = fileRepository;
            // 系統啟動時自動載入資料
            _students = _fileRepository.LoadDataFromJson();
        }

        // 1. 新增學生
        public void AddStudent(string studentId, string name, string className)
        {
            // 檢查學號是否已存在
            // _students.Any() = 檢查列表中是否有任何學生符合條件
            // s => s.StudentId == studentId = 條件：學生的學號等於傳入的學號
            if (_students.Any(s => s.StudentId == studentId))
            {
                throw new InvalidOperationException("學號已存在！");
            }

            // 要建立實際的物件，必須用 new
            // Student student1 = new Student("A001", "張三", "資工一甲");  建立物件1
            // Student student2 = new Student("A002", "李四", "資工一乙");  建立物件2
            _students.Add(new Student(studentId, name, className));
            _fileRepository.SaveDataToJson(_students); // 每次異動後自動儲存
        }

        // 2. 取得所有學生
        // 建立一個 GetAllStudents() 方法
        // 將 _students 回傳給呼叫這個方法的人
        // 回傳型別是 List<Student>
        public List<Student> GetAllStudents()
        {
            return _students;
        }

        // 3. 為指定學生新增成績
        public void AddGrade(string studentId, string subject, double score)
        {
            var student = _students.FirstOrDefault(s => s.StudentId == studentId);
            if (student == null)
            {
                throw new InvalidOperationException("找不到指定的學生！");
            }
            student.Grades.Add(new Grade(subject, score));
            _fileRepository.SaveDataToJson(_students); // 每次異動後自動儲存

        }

        // 4. 查詢某位學生的所有成績
        public List<Grade> GetStudentGrades(string studentId)
        {
            var student = _students.FirstOrDefault(s => s.StudentId == studentId);
            return student?.Grades ?? new List<Grade>(); // 如果找不到學生，返回空列表
        }

        // 5. 使用 LINQ 進行成績分析
        public (double average, double highest, double lowest) GetStudentStatistics(string studentId)
        {
            var student = _students.FirstOrDefault(s => s.StudentId == studentId);
            if (student == null || !student.Grades.Any())
            {
                return (0, 0, 0); // 沒有成績，返回 0
            }

            // 使用 LINQ 進行計算
            double average = student.Grades.Average(g => g.Score);
            double highest = student.Grades.Max(g => g.Score);
            double lowest = student.Grades.Min(g => g.Score);

            return (average, highest, lowest);
        }

        // 6. 查詢全班前 3 名
        public List<Student> GetTop3Students()
        {
            // 過濾出有成績的學生
            return _students
                .Where(s => s.Grades.Any())
                // 根據平均分數進行降序排序
                // 從學生列表中，找出每一位學生的所有成績，計算出他們的平均分數，然後根據這個平均分數，將學生們從高分到低分進行排序。
                .OrderByDescending(s => s.Grades.Average(g => g.Score))
                // 取前 3 名
                .Take(3)
                .ToList();
        }

        // 7. 取得所有科目

        public List<string> GetAllSubjects()
        {
            var subjects = new List<string>();
            foreach (var student in _students)
            {
                foreach (var grade in student.Grades)
                {
                    if (!subjects.Contains(grade.Subject))
                    {
                        subjects.Add(grade.Subject);
                    }
                }
            }
            subjects.Sort();
            return subjects;
        }

        // 8. 取得指定科目的最高分和最低分

        public (double highest, double lowest, int studentCount) GetStudentStatus(string subject)
        {
            var scores = new List<double>();
            foreach (var student in _students)
            {
                foreach (var grade in student.Grades)
                {
                    if (grade.Subject == subject)
                    {
                        scores.Add(grade.Score);
                    }
                }
            }

            if (scores.Count == 0)
            {
                return (0, 0, 0);
            }

            double highest = scores[0];
            double lowest = scores[0];

            foreach (var score in scores)
            {
                if (score > highest) { highest = score; }
                if (score < lowest) { lowest = score; }
            }

            return (highest, lowest, scores.Count);
        }
    }

        

}
