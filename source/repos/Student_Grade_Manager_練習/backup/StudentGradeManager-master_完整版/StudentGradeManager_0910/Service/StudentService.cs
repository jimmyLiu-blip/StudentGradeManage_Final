using StudentGradeManager_0910_Domain;
using StudentGradeManager_0910_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace StudentGradeManager_0910.Service
{
    public class StudentService
    {
        private readonly FileRepository _fileRepository;
        private List<Student> _students;

        public StudentService(FileRepository fileRepository)
        { 
            _fileRepository = fileRepository;
            _students = _fileRepository.LoadDataFromJson();
        }

        // 1.新增學生
        public void AddStudent(string numberId, string name, string className)
        {
                if (_students.Any(s => s.NumberId == numberId))
                {
                    throw new InvalidOperationException("此學生的學號已存在");
                    // return; 多餘的，throw就會立即中止方法
                }

                _students.Add(new Student(numberId, name, className));
                _fileRepository.SaveDataToJson(_students);
        }

        // 2. 取得所有學生
        public List<Student> GetAllStudent()
        { 
            return _students;
        }

        // 3. 為指定學生新增成績
        public void AddStudentGrade(string numberId, string subject, double score)
        {
            // FirstOrDefault() 回傳預設值。對於參考型別(class)，預設值是null；對於數值型別(int)，預設值是0
            var student = _students.FirstOrDefault(s => s.NumberId == numberId);
                if (student == null)
                {
                    throw new InvalidOperationException("此學生不存在，無法新增成績");
                }

                student.Grades.Add(new Grade(subject, score));
                _fileRepository.SaveDataToJson(_students);
        }

        // 4.尋找某位學生的所有成績

        public List<Grade> GetStudentGrades(string numberId)
        {
            var student = _students.FirstOrDefault(s => s.NumberId == numberId);

            return student?.Grades?? new List<Grade>();

        }

        // 5.使用LINQ成績分析

        public (double average, double highest, double lowest) GetStudentStatistics(string numberId)
        {
            var student = _students.FirstOrDefault(s => s.NumberId == numberId);
            // if (student == null || student.Grades.Any())
            if (student == null || !student.Grades.Any())
            {
                return (0, 0, 0);
            }

            double average = student.Grades.Average(g => g.Score);
            double highest = student.Grades.Max(g => g.Score);
            double lowest = student.Grades.Min(g => g.Score);
            return (average, highest, lowest);
        }

        // 6.查詢全班前3名

        public List<Student> GetStudents3Top()
        { 
            return _students
                .Where(s=>s.Grades.Any())
                .OrderByDescending(s=>s.Grades.Average(g=>g.Score))
                .Take(3)
                .ToList();
        }

        // 7.取得所有科目
        public List<string> GetAllSubjects()
        { 
            // 創建一個空字串列表，用來儲存所有科目名稱
            var subjects = new List<string>();

            // 遍歷所有學生，student代表當前正在處理的學生物件
            foreach (var student in _students)
            {
                // 遍歷當前學生的所有成績，grade代表當前正在處理的成績物件
                foreach (var grade in student.Grades)
                {
                    // 檢查科目列表中，是否不包含當前成績的科目
                    if (!subjects.Contains(grade.Subject))
                    { 
                        // 如果科目列表中沒有這個科目，就加入到列表中
                        // 這樣可以避免重複的科目
                        subjects.Add(grade.Subject);
                    }
                }
            }
            subjects.Sort(); //排序
            return subjects;
        }

        // 8.取得指定科目的最高分和最低分

        // 回傳一個Tuple，包含最高分、最低分、學生人數
        // 宣告方法(Method)的回傳型別
        public (double highest, double lowest, int studentCount) GetSubjectStats(string subject)
        {
            // 創建一個空的數字列表，用來儲存指定科目的所有分數
            var scores = new List<double>();
            // 遍歷所有學生
            foreach (var student in _students)
            {   // 遍歷每個學生的所有成績
                foreach (var grade in student.Grades)
                {
                    // 檢查當前成績的科目是否等於我們要查詢的科目
                    // 只統計指定科目成績的關鍵篩選條件
                    if (grade.Subject == subject)
                        
                    {
                        // 如果科目符合，就把分數加入到分數列表中
                        scores.Add(grade.Score);
                    }
                }
            }

            // 檢查分數列表是否為空(沒有找到任何該科目的成績)
            if (scores.Count == 0)
            {
                // 如果沒有成績，回傳(0,0,0)
                return (0, 0, 0);
            }

            // 將第一個分數設為最高分的初始值
            double highest = scores[0];
            // 將第一個分數設為最低分的初始值
            double lowest = scores[0];

            // 遍歷所有分數
            foreach (var score in scores)
            { 
                // 如果當前分數比目前記錄的最高分還高，就更新最高分
                // 可以使用 highest = Math.Max(highest, score)
                if(score > highest) { highest = score; }
                // 如果當前分數比目前記錄的最低分還低，就更新最低分
                // 可以使用 lowest = Math.Min(lowest, score)
                if(score < lowest) {lowest = score; }
            }

            // 回傳最高分、最低分、總共有多少學生考了這個科目
            return (highest, lowest, scores.Count);
        }
    }
}

 