namespace Student_Grade_Manager
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
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(91, 42);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 29);
            this.txtStudentId.TabIndex = 0;
            this.txtStudentId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(91, 95);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 29);
            this.txtStudentName.TabIndex = 1;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(91, 151);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 29);
            this.txtClassName.TabIndex = 2;
            this.txtClassName.TextChanged += new System.EventHandler(this.txtClassName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "學號：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "班級：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveStudent.Location = new System.Drawing.Point(56, 203);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(97, 47);
            this.btnSaveStudent.TabIndex = 6;
            this.btnSaveStudent.Text = "儲存";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(24, 272);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 62;
            this.dgvStudents.RowTemplate.Height = 31;
            this.dgvStudents.Size = new System.Drawing.Size(240, 150);
            this.dgvStudents.TabIndex = 7;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(482, 46);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(100, 26);
            this.cmbStudents.TabIndex = 8;
            this.cmbStudents.SelectedIndexChanged += new System.EventHandler(this.cmbStudents_SelectedIndexChanged);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(482, 96);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 29);
            this.txtSubject.TabIndex = 9;
            this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(482, 148);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 29);
            this.txtScore.TabIndex = 10;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddGrade.Location = new System.Drawing.Point(482, 203);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(88, 47);
            this.btnAddGrade.TabIndex = 11;
            this.btnAddGrade.Text = "新增";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "科目：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "分數：";
            // 
            // dgvGrades
            // 
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(426, 272);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.RowHeadersWidth = 62;
            this.dgvGrades.RowTemplate.Height = 31;
            this.dgvGrades.Size = new System.Drawing.Size(240, 150);
            this.dgvGrades.TabIndex = 14;
            this.dgvGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "學生列表：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(147, 115);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(8, 28);
            this.textEdit1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 493);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}

