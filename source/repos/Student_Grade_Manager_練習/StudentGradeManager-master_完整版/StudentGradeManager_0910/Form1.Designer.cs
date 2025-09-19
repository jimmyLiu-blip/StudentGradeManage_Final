namespace StudentGradeManager_0910
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblScoreMax = new System.Windows.Forms.Label();
            this.lblScoreMin = new System.Windows.Forms.Label();
            this.btnGrade = new System.Windows.Forms.Button();
            this.listTop3 = new System.Windows.Forms.ListBox();
            this.btnGet3 = new System.Windows.Forms.Button();
            this.cmbSubjectStats = new System.Windows.Forms.ComboBox();
            this.btnSubjectStats = new System.Windows.Forms.Button();
            this.lblSubjectStatsResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "學號:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "班級:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(124, 36);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(133, 29);
            this.txtStudentId.TabIndex = 6;
            this.txtStudentId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(124, 79);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(133, 29);
            this.txtStudentName.TabIndex = 7;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(124, 117);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(133, 29);
            this.txtClassName.TabIndex = 8;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(33, 27);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 62;
            this.dgvStudents.RowTemplate.Height = 31;
            this.dgvStudents.Size = new System.Drawing.Size(337, 224);
            this.dgvStudents.TabIndex = 12;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvGrades
            // 
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(33, 266);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            this.dgvGrades.RowHeadersWidth = 62;
            this.dgvGrades.RowTemplate.Height = 31;
            this.dgvGrades.Size = new System.Drawing.Size(337, 224);
            this.dgvGrades.TabIndex = 13;
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Location = new System.Drawing.Point(275, 64);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(84, 54);
            this.btnSaveStudent.TabIndex = 14;
            this.btnSaveStudent.Text = "新增";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAverageScore.Location = new System.Drawing.Point(171, 31);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(130, 24);
            this.lblAverageScore.TabIndex = 16;
            this.lblAverageScore.Text = "平均分數：";
            this.lblAverageScore.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblScoreMax
            // 
            this.lblScoreMax.AutoSize = true;
            this.lblScoreMax.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScoreMax.Location = new System.Drawing.Point(171, 81);
            this.lblScoreMax.Name = "lblScoreMax";
            this.lblScoreMax.Size = new System.Drawing.Size(130, 24);
            this.lblScoreMax.TabIndex = 17;
            this.lblScoreMax.Text = "最高分數：";
            // 
            // lblScoreMin
            // 
            this.lblScoreMin.AutoSize = true;
            this.lblScoreMin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScoreMin.Location = new System.Drawing.Point(171, 137);
            this.lblScoreMin.Name = "lblScoreMin";
            this.lblScoreMin.Size = new System.Drawing.Size(130, 24);
            this.lblScoreMin.TabIndex = 18;
            this.lblScoreMin.Text = "最低分數：";
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(30, 53);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(101, 52);
            this.btnGrade.TabIndex = 22;
            this.btnGrade.Text = "計算";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.button1_Click);
            // 
            // listTop3
            // 
            this.listTop3.FormattingEnabled = true;
            this.listTop3.ItemHeight = 18;
            this.listTop3.Location = new System.Drawing.Point(160, 187);
            this.listTop3.Name = "listTop3";
            this.listTop3.Size = new System.Drawing.Size(298, 76);
            this.listTop3.TabIndex = 23;
            this.listTop3.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnGet3
            // 
            this.btnGet3.Location = new System.Drawing.Point(30, 197);
            this.btnGet3.Name = "btnGet3";
            this.btnGet3.Size = new System.Drawing.Size(101, 47);
            this.btnGet3.TabIndex = 24;
            this.btnGet3.Text = "查詢前3名";
            this.btnGet3.UseVisualStyleBackColor = true;
            this.btnGet3.Click += new System.EventHandler(this.btnGet3_Click);
            // 
            // cmbSubjectStats
            // 
            this.cmbSubjectStats.FormattingEnabled = true;
            this.cmbSubjectStats.Location = new System.Drawing.Point(16, 298);
            this.cmbSubjectStats.Name = "cmbSubjectStats";
            this.cmbSubjectStats.Size = new System.Drawing.Size(133, 26);
            this.cmbSubjectStats.TabIndex = 25;
            this.cmbSubjectStats.SelectedIndexChanged += new System.EventHandler(this.cmbSubjectStats_SelectedIndexChanged);
            // 
            // btnSubjectStats
            // 
            this.btnSubjectStats.Location = new System.Drawing.Point(30, 341);
            this.btnSubjectStats.Name = "btnSubjectStats";
            this.btnSubjectStats.Size = new System.Drawing.Size(101, 46);
            this.btnSubjectStats.TabIndex = 26;
            this.btnSubjectStats.Text = "查詢統計";
            this.btnSubjectStats.UseVisualStyleBackColor = true;
            this.btnSubjectStats.Click += new System.EventHandler(this.btnSubjectStats_Click);
            // 
            // lblSubjectStatsResult
            // 
            this.lblSubjectStatsResult.AutoSize = true;
            this.lblSubjectStatsResult.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSubjectStatsResult.Location = new System.Drawing.Point(171, 300);
            this.lblSubjectStatsResult.Name = "lblSubjectStatsResult";
            this.lblSubjectStatsResult.Size = new System.Drawing.Size(130, 24);
            this.lblSubjectStatsResult.TabIndex = 27;
            this.lblSubjectStatsResult.Text = "成績結果：";
            this.lblSubjectStatsResult.Click += new System.EventHandler(this.lblSubjectStatsResult_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStudentId);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.btnSaveStudent);
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 168);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StudentManage";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGrade);
            this.groupBox3.Controls.Add(this.lblAverageScore);
            this.groupBox3.Controls.Add(this.lblScoreMax);
            this.groupBox3.Controls.Add(this.lblSubjectStatsResult);
            this.groupBox3.Controls.Add(this.lblScoreMin);
            this.groupBox3.Controls.Add(this.cmbSubjectStats);
            this.groupBox3.Controls.Add(this.btnSubjectStats);
            this.groupBox3.Controls.Add(this.btnGet3);
            this.groupBox3.Controls.Add(this.listTop3);
            this.groupBox3.Location = new System.Drawing.Point(31, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 419);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GradeStastic";
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(276, 70);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(84, 54);
            this.btnAddGrade.TabIndex = 15;
            this.btnAddGrade.Text = "新增";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(24, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "分數:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(124, 131);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(133, 29);
            this.txtScore.TabIndex = 10;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(124, 85);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(133, 29);
            this.txtSubject.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(24, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "科目:";
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(124, 50);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(133, 26);
            this.cmbStudents.TabIndex = 11;
            this.cmbStudents.SelectedIndexChanged += new System.EventHandler(this.cmbStudents_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "學生列表:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbStudents);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSubject);
            this.groupBox2.Controls.Add(this.txtScore);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAddGrade);
            this.groupBox2.Location = new System.Drawing.Point(16, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 166);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GradeManage";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(421, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 463);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "學生/成績新增";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "成績分析";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblScoreMax;
        private System.Windows.Forms.Label lblScoreMin;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.ListBox listTop3;
        private System.Windows.Forms.Button btnGet3;
        private System.Windows.Forms.ComboBox cmbSubjectStats;
        private System.Windows.Forms.Button btnSubjectStats;
        private System.Windows.Forms.Label lblSubjectStatsResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

