using StudentGradeManager_0910.Service;
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
using Microsoft.VisualBasic;

namespace StudentGradeManager_0910
{
    public partial class Form1 : Form
    {
        private readonly StudentService _studentService;
        public Form1()
        {
            InitializeComponent();

            _studentService = new StudentService(new FileRepository());

            RefreshStudentList();

            // 綁定雙擊事件到 DataGridView
            dgvGrades.CellDoubleClick += dgvGrades_CellDoubleClick;
        }

        private void RefreshStudentList()
        {
            var student = _studentService.GetAllStudent();
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = student;

            cmbStudents.DataSource = null ;
            cmbStudents.DataSource = student;
            cmbStudents.DisplayMember = "Name";
            cmbStudents.ValueMember = "NumberId";

            LoadSubjects();
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
                string numberId = txtStudentId.Text.Trim();
                string name = txtStudentName.Text.Trim();
                string className = txtClassName.Text.Trim();

                if (string.IsNullOrEmpty(numberId) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(className))
                {
                    MessageBox.Show("學號、姓名、班級任一不可為空", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                 _studentService.AddStudent(numberId, name, className);

                MessageBox.Show("新增學生成功","輸入正確",MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshStudentList();

                txtStudentId.Clear();
                txtStudentName.Clear();
                txtClassName.Clear();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"出現異常錯誤，{ex.Message}", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbStudents.SelectedValue == null)
            {
                // MessageBox.Show("至少選擇一位學生", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string numberId = cmbStudents.SelectedValue.ToString();

            // 新增加的步驟
            var student = _studentService.GetAllStudent().FirstOrDefault(s => s.NumberId == numberId);

            if (student != null)
            {
                txtStudentId.Text = student.NumberId;
                txtStudentName.Text = student.Name;
                txtClassName.Text = student.ClassName;
            }

            // _studentService.GetStudentGrades(numberId);
            // 以下步驟為缺少的

            var grades = _studentService.GetStudentGrades(numberId);

            dgvGrades.DataSource = null;

            dgvGrades.DataSource = grades;

        }
        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            try
            {     
                string subject = txtSubject.Text.Trim();

                if (cmbStudents.SelectedValue == null || string.IsNullOrEmpty(subject) || double.TryParse(subject,out _))
                {
                    MessageBox.Show("至少選擇一位學生且科目不可以為空字串或數字", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string numberId = cmbStudents.SelectedValue.ToString();

                if (!double.TryParse(txtScore.Text, out double score))
                {
                    MessageBox.Show("成績請輸入數字","輸入錯誤",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _studentService.AddStudentGrade(numberId, subject, score);

                MessageBox.Show("新增學生成績成功", "輸入正確", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // 這樣寫比起直接使用RefreshStudentList();要節省效能

                var studentGrades = _studentService.GetStudentGrades(numberId);

                dgvGrades.DataSource = null;

                dgvGrades.DataSource = studentGrades;

                LoadSubjects();

                txtSubject.Clear();
                txtScore.Clear();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"出現異常錯誤，{ex.Message}", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedValue == null)
            {
                MessageBox.Show("至少選擇一位學生", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string numberId = cmbStudents.SelectedValue.ToString();

                var stastics = _studentService.GetStudentStatistics(numberId);

                lblAverageScore.Text = $"平均分數:{stastics.average:F2}";
                lblScoreMax.Text = $"最高分數:{stastics.highest:F2}";
                lblScoreMin.Text = $"最低分數:{stastics.lowest:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"出現異常錯誤{ex.Message}", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdataTop3List();
        }

        private void btnGet3_Click(object sender, EventArgs e)
        {
            UpdataTop3List();
        }
        private void UpdataTop3List()
        {
            try
            {
                var top3Students = _studentService.GetStudents3Top();

                // 先清空列表避免重複
                listTop3.Items.Clear();

                if (!top3Students.Any())
                {
                    listTop3.Items.Add("目前沒有學生資料");
                    return;
                }

                int rank = 1;
                foreach (var student in top3Students)
                {
                    listTop3.Items.Add($"第{rank}名：{student.Name}\t,平均分數：{student.Grades.Average(g => g.Score):F2}");
                    rank++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查詢失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSubjectStatsResult_Click(object sender, EventArgs e)
        {

        }

        // 新增：獨立的載入科目方法
        private void LoadSubjects()
        {
            var subjects = _studentService.GetAllSubjects();

            cmbSubjectStats.Items.Clear();
            foreach (var subject in subjects)
            {
                cmbSubjectStats.Items.Add(subject);
            }
        }


        // 新增：載入科目到下拉選單
        private void cmbSubjectStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 可以留空
        }

        // 新增：科目統計按鈕點擊事件
        private void btnSubjectStats_Click(object sender, EventArgs e)
        {
            if (cmbSubjectStats.SelectedItem == null)
            {
                MessageBox.Show("請選擇一個科目", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string subject = cmbSubjectStats.SelectedItem.ToString();
                var stats = _studentService.GetSubjectStats(subject);

                if (stats.studentCount == 0)
                {
                    lblSubjectStatsResult.Text = $"科目：{subject}目前沒有成績";
                }
                else
                {
                    lblSubjectStatsResult.Text = $"科目：{subject}\n" +
                                            $"最高分：{stats.highest:F2}\n" +
                                            $"最低分：{stats.lowest:F2}\n" +
                                            $"共{stats.studentCount}位學生";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查詢失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdataStudent_Click(object sender, EventArgs e)
        {
            try 
            {
                string numberId = txtStudentId.Text.Trim();
                string newName = txtStudentName.Text.Trim();
                string newClassName = txtClassName.Text.Trim();

                if (string.IsNullOrEmpty(numberId) || string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newClassName))
                {
                    MessageBox.Show("學號、姓名、班級任一不可為空", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _studentService.UpdateStudent(numberId, newName, newClassName);

                MessageBox.Show("更新學生資訊成功", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshStudentList();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"出現異常錯誤，{ex.Message}", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dgvGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGrades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // 避免點擊標題列

            var selectedRow = dgvGrades.Rows[e.RowIndex];
            string numberId = cmbStudents.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(numberId))
            {
                MessageBox.Show("請先選擇一位學生。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 取得當前選定的科目和成績
            string oldSubject = selectedRow.Cells["Subject"].Value?.ToString();
            double oldScore = double.Parse(selectedRow.Cells["Score"].Value?.ToString());

            // 彈出對話框讓使用者輸入新值
            string newSubject = Interaction.InputBox("請輸入新的科目名稱:", "修改科目", oldSubject);
            string newScoreString = Interaction.InputBox("請輸入新的成績:", "修改成績", oldScore.ToString());

            // 檢查使用者輸入
            if (string.IsNullOrEmpty(newSubject) || string.IsNullOrEmpty(newScoreString))
            {
                MessageBox.Show("科目和成績不能為空。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(newScoreString, out double newScore))
            {
                MessageBox.Show("成績請輸入數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _studentService.UpdateStudentGrade(numberId, oldSubject, newSubject, newScore);
                MessageBox.Show("成績更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 刷新成績列表
                var studentGrades = _studentService.GetStudentGrades(numberId);
                dgvGrades.DataSource = null;
                dgvGrades.DataSource = studentGrades;

                LoadSubjects(); // 刷新科目下拉選單
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
