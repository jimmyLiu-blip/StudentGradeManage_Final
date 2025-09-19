using StudentGradeManager_0910.Service;
using StudentGradeManager_0910_Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentGradeManager_0910_Domain
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

/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentGradeManager_0910_Domain;
using StudentGradeManager_0910_Repository;

namespace StudentGradeManager_0910
{
    public partial class Form1 : Form
    {
        private StudentService _studentService;
        public Form1()
        {
            InitializeComponent();

            _studentService = new StudentService(new FileRepository());

            RefreshStudentList();
        }

        private void RefreshStudentList()
        {
            var students = _studentService.GetAllStudents();
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;

            cmbStudents.DataSource = null;
            cmbStudents.DataSource = students;
            cmbStudents.DisplayMember = "Name";     // cmbStudents：顯示用名字
            cmbStudents.ValueMember = "StudentId";  // 取值使用學號來辨別
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // txtStudentId是一個物件 / Text是屬性 / Trim()是字串型別的方法
                string studentId = txtStudentId.Text.Trim();
                string name = txtStudentName.Text.Trim();
                string className = txtClassName.Text.Trim();

                // 呼叫string類別的靜態方法IsNullOrEmpty，並將studentId這個變數作為參數傳入進行判斷
                if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(className))
                {
                    // MessageBox.Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
                    // 是最常見且功能最完整的版本之一，string text：這是訊息視窗內部的文字
                    // string caption：訊息視窗頂部的標題列文字。
                    // MessageBoxButtons.OK：這是按鈕配置。這告訴訊息視窗只顯示一個「確定」按鈕
                    // 其他選項還有：MessageBoxButtons.OKCancel(確定、取消)、MessageBoxButtons.YesNo(是、否)、MessageBoxButtons.RetryCancel(重試、取消)。
                    // MessageBoxIcon.Warning：這是圖示配置。這會在訊息視窗左側顯示一個黃色的警告圖示。
                    // 其他選項還有：MessageBoxIcon.Information (資訊，一個藍色 i 圓圈)、MessageBoxIcon.Error (錯誤，一個紅色 x 圓圈)、MessageBoxIcon.Question (問題，一個藍色問號)。
                    // MessageBox.Show是一個靜態方法 (static method)，它屬於 MessageBox 這個類別，但不是 MessageBox 這個型別的物件。
                    // 靜態方法最大的特點就是：不需要建立物件，就能直接呼叫。
                    MessageBox.Show("學號、姓名、班級不可以有空的", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // return 在使用者輸入為空時，停止後續程式碼的執行
                    return;
                }

                _studentService.AddStudent(studentId, name, className);
                MessageBox.Show("學生新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshStudentList();

                //txtStudentId.Text.Clear(); Text是一個字串(string),而字串本身沒有Clear()方法
                txtStudentId.Clear();
                txtStudentName.Clear();
                txtClassName.Clear();

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增學生時發生了未知的錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cmbStudents.SelectedValue 功能和 cmbStudents_SelectedIndexChanged 不同
            if (cmbStudents.SelectedValue == null)
                return;

            string studentId = cmbStudents.SelectedValue.ToString();
            var studentGrades = _studentService.GetStudentGrades(studentId);

            dgvGrades.DataSource = null;
            dgvGrades.DataSource = studentGrades;

        }
    }
}
*/