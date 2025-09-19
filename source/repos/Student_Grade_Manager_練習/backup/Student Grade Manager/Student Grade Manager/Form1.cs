using Student_Grade_Manager.Repository;
using Student_Grade_Manager.Service; // 確保你有正確的命名空間
using System;
using System.Windows.Forms;

namespace Student_Grade_Manager
{
    public partial class Form1 : Form
    {
        private StudentService _studentService;  // 建立一個容器_studentService用來存放StudentService的實例，private StudentService _studentService; 宣告了一個私有 (private) 的欄位 _studentService，它的資料型別是 StudentService。

        //public Form1(StudentService studentService)
        //{
        //    InitializeComponent();
        //     _studentService = studentService;  // 使用外部提供的實例
        //     RefreshStudentList();
        //} 
        //也可以使用上面的程式寫法，使用依賴注入，使用外部提供的實例(更推薦使用)
        public Form1()
        {
            InitializeComponent();
            // 在 Form 啟動時初始化服務層
            _studentService = new StudentService(new FileRepository()); // 自己建立實例

            // 程式啟動時，可以呼叫一個方法來載入並顯示資料，例如：
            // LoadAndDisplayStudents();
            // 程式啟動時自動載入並顯示資料
            RefreshStudentList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 從 UI 介面取得使用者輸入的資料
                string studentId = txtStudentId.Text.Trim();
                string name = txtStudentName.Text.Trim();
                string className = txtClassName.Text.Trim(); // 假設你新增了班級輸入框

                // 檢查輸入是否為空
                if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(className))
                {
                    MessageBox.Show("學號與姓名與班級都不能為空！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. 將資料傳遞給 StudentService 的 AddStudent 方法
                // 這裡就是 UI 層與 Service 層的互動
                _studentService.AddStudent(studentId, name, className); // 你可以為班級設定預設值或新增一個輸入框

                // 3. 顯示成功訊息給使用者，並清空輸入框
                MessageBox.Show("學生新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshStudentList();

                txtStudentId.Clear();
                txtStudentName.Clear();
                txtClassName.Clear();

                // 4. (可選) 重新整理畫面，顯示更新後的學生列表
                //RefreshStudentList();
            }
            catch (InvalidOperationException ex)
            {
                // 如果 Service 層拋出例外（例如學號重複），我們在這裡捕獲並顯示給使用者
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // 處理其他未預期的錯誤
                MessageBox.Show($"新增學生時發生了未知的錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshStudentList()
        {
            // 從 Service 層取得所有學生資料的列表
            var students = _studentService.GetAllStudents();

            // 將 DataGridView 的資料來源設定為這個列表
            // DataGridView 會自動生成欄位來顯示學號、姓名、班級等屬性
            // 更新 DataGridView
            dgvStudents.DataSource = null;
            // DataSource是一個屬性，功能是讓 DataGridView 控制項知道資料從哪裡來。
            // 它負責將資料來源（例如 List<Student>）與 DataGridView 的列和行綁定 (Binding) 在一起。
            // 先清除舊的資料源
            // 像一個「重置鍵」。明確告訴 DataGridView：「我要換一份全新的資料，請先忘記所有舊的連結和快取，重新準備好迎接新的資料。」
            dgvStudents.DataSource = students;

            // 填充 ComboBox，讓使用者選擇學生
            // 更新 ComboBox
            // 這一行很重要，它會讓 ComboBox 重新綁定最新的學生列表
            cmbStudents.DataSource = null;
            cmbStudents.DataSource = students;
            cmbStudents.DisplayMember = "Name";       // 在 ComboBox 中顯示學生的姓名
            cmbStudents.ValueMember = "StudentId";    // 但實際取值時，我們用學號來識別
            // 為了顯示成績，可能需要手動處理或使用 DataGridView 的子視圖，
            // 這部分可以作為進階功能之後再考慮。
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 檢查是否有選取項目
            if (cmbStudents.SelectedValue == null) 
                return; //結束程式，避免程式繼續往下

            // 取得所選學生的學號
            // cmbStudents.SelectedValue 回傳的資料型別是 object，而不是 string
            // ToString() 的作用是將任何非字串（non-string）的物件轉換成字串（string）。
            string studentId = cmbStudents.SelectedValue.ToString();

            // 呼叫 Service 層方法，取得該學生的所有成績
            var studentGrades = _studentService.GetStudentGrades(studentId);

            // 將成績列表繫結到 dgvGrades
            dgvGrades.DataSource = null; // 清除舊資料
            dgvGrades.DataSource = studentGrades;
        }
        private void btnAddGrade_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 檢查是否選擇了學生
                if (cmbStudents.SelectedValue == null)
                {
                    MessageBox.Show("請先選擇一位學生！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 取得所選學生的學號
                string studentId = cmbStudents.SelectedValue.ToString();
                string subject = txtSubject.Text.Trim();

                // 負責驗證使用者輸入的分數是否為有效的數字。
                // double.TryParse()是double中的靜態方法，用來嘗試解析一個字串，看它是否能被轉換成 double 型別的數字
                // out double score:是 TryParse 方法的一個特殊用法。如果解析成功，它會將轉換後的數字儲存到這個新的 score 變數中
                if (!double.TryParse(txtScore.Text, out double score))
                {
                    MessageBox.Show("分數輸入無效，請輸入數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 呼叫 Service 層方法，新增成績
                _studentService.AddGrade(studentId, subject, score);

                MessageBox.Show("成績新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 新增成績後，更新 dgvGrades，讓使用者立即看到結果
                var studentGrades = _studentService.GetStudentGrades(studentId);
                dgvGrades.DataSource = studentGrades;

                // 提醒：不需要呼叫 RefreshStudentList()，因為新增成績不會影響學生基本資料
                // 但如果未來需要顯示平均分數等計算值，就必須呼叫 RefreshStudentList()
                // 以更新 dgvStudents。
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
