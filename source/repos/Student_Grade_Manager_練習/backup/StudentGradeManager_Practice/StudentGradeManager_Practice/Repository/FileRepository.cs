using StudentGradeManager_Practice.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.Json;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace StudentGradeManager_Practice.Repository
{
    public class FileRepository
    {
        private readonly string _filePath = "Student.data.json";

        public void SaveDataToJson(List<Student> students)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                string jsonString = JsonSerializer.Serialize(students, options);
                File.WriteAllText(_filePath, jsonString);
            }
            catch (Exception e)
            {
                Console.WriteLine($"出現異常錯誤，無法順利儲存檔案，{e.Message}");
            }
        }

        public List<Student> LoadDataToJson()
        {
            if (!File.Exists(_filePath))
            {
                Console.WriteLine("檔案不存在，無法讀檔");
                //
                return new List<Student>(); // 如果檔案不存在，返回一個空的列表
            }
            try
            {
                string jsonString = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<Student>>(jsonString);
            }
            catch (Exception e)
            {
                Console.WriteLine($"出現異常錯誤，無法順利存檔，{e.Message}");
                return new List<Student>();
            }

        }
    }
}
