using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;
using StudentGradeManager_0910_Domain;

namespace StudentGradeManager_0910_Repository
{
    public class FileRepository
    {
        private readonly string _filePath = "student_data.json";
        public void SaveDataToJson(List<Student> students)
        {
            // 忘記使用try、catch
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };
                var jsonString = JsonSerializer.Serialize(students, options);
                File.WriteAllText(_filePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"遇到異常錯誤，無法存檔，{ex.Message}");
            }
        }

        public List<Student> LoadDataFromJson()
        {
            if (!File.Exists(_filePath))
            {
                // Console.WriteLine($"檔案不存在，無法順利載入");
                return new List<Student>();
            }
            try
            {
                string jsonString = File.ReadAllText(_filePath);

                return JsonSerializer.Deserialize<List<Student>>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"出現異常錯誤，無法順利讀檔，{ex.Message}");
                return new List<Student>();
            }
        }
    }
}