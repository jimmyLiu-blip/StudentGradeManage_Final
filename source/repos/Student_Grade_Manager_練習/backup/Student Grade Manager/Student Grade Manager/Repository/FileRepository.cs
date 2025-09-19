using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System;
using Student_Grade_Manager.Domain;

namespace Student_Grade_Manager.Repository
{
    // 將學生資料列表儲存到 JSON 檔案
    public class FileRepository
    {
        // 指定一個唯獨的路徑檔案，名稱為"student_data.json"
        private readonly string _filePath = "student_data.json";

        /// <summary>
        /// 這行程式碼的 List<Student> students 本身就是一個參數宣告。這意味著當你呼叫這個方法時，你必須傳入一個已經存在的 List<Student> 物件。
        /// 可以把 SaveDataToJson 方法想像成一個函式，它的職責是「把收到的學生列表存檔」。它不關心這個列表是從哪裡來的，也不負責建立這個列表。它的工作就是把已經準備好的資料，轉換成 JSON 並寫入檔案。
        /// </summary>
        /// <param name="students"></param>
        public void SaveDataToJson(List<Student> students)
        {
            // JsonSerializerOptions 是一個 C# 內建的類別，它包含了各種選項，可以讓你控制 JSON 的序列化（將物件轉成 JSON 字串）和反序列化（將 JSON 字串轉成物件）行為。
            // new JsonSerializerOptions { ... } 是一種簡潔的物件初始化語法。它會建立一個 JsonSerializerOptions 的新物件，並立即設定物件的屬性。
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                string jsonString = JsonSerializer.Serialize(students, options);
                File.WriteAllText(_filePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"儲存檔案時發生錯誤: {ex.Message}");
            }
        }

        // 從 JSON 檔案載入學生資料列表
        public List<Student> LoadDataFromJson() // 這表示會返回一個 Student 物件的列表
        {
            if (!File.Exists(_filePath))
            {
                return new List<Student>(); // 如果檔案不存在，返回一個空的列表
            }

            try
            {
                string jsonString = File.ReadAllText(_filePath);
                // 反序列化，將 JSON 字串轉回 List<Student> 物件
                return JsonSerializer.Deserialize<List<Student>>(jsonString);
            }
            catch (Exception ex)
            {
                // 處理反序列化錯誤，例如檔案內容格式不正確
                Console.WriteLine($"讀取檔案時發生錯誤: {ex.Message}");
                return new List<Student>(); // 讀取失敗也返回空的列表，避免程式當掉
            }
        }
    }

    

}
