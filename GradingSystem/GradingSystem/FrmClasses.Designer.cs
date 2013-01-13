namespace GradingSystem
{
    partial class FrmClasses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coursecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxenrollmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProfessor = new System.Windows.Forms.ComboBox();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddClass = new System.Windows.Forms.Button();
            this.txtMaxEnroll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSemesters = new System.Windows.Forms.ComboBox();
            this.semesterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCourses = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 395);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coursecodeDataGridViewTextBoxColumn,
            this.semesteridDataGridViewTextBoxColumn,
            this.maxenrollmentDataGridViewTextBoxColumn,
            this.enrollmentDataGridViewTextBoxColumn,
            this.classtimeDataGridViewTextBoxColumn,
            this.professoridDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn,
            this.semesterYearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 239);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowDividerDoubleClick += new System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler(this.dataGridView1_RowDividerDoubleClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // coursecodeDataGridViewTextBoxColumn
            // 
            this.coursecodeDataGridViewTextBoxColumn.DataPropertyName = "Course_code";
            this.coursecodeDataGridViewTextBoxColumn.HeaderText = "Course_code";
            this.coursecodeDataGridViewTextBoxColumn.Name = "coursecodeDataGridViewTextBoxColumn";
            // 
            // semesteridDataGridViewTextBoxColumn
            // 
            this.semesteridDataGridViewTextBoxColumn.DataPropertyName = "Semester_id";
            this.semesteridDataGridViewTextBoxColumn.HeaderText = "Semester_id";
            this.semesteridDataGridViewTextBoxColumn.Name = "semesteridDataGridViewTextBoxColumn";
            // 
            // maxenrollmentDataGridViewTextBoxColumn
            // 
            this.maxenrollmentDataGridViewTextBoxColumn.DataPropertyName = "Max_enrollment";
            this.maxenrollmentDataGridViewTextBoxColumn.HeaderText = "Max_enrollment";
            this.maxenrollmentDataGridViewTextBoxColumn.Name = "maxenrollmentDataGridViewTextBoxColumn";
            // 
            // enrollmentDataGridViewTextBoxColumn
            // 
            this.enrollmentDataGridViewTextBoxColumn.DataPropertyName = "Enrollment";
            this.enrollmentDataGridViewTextBoxColumn.HeaderText = "Enrollment";
            this.enrollmentDataGridViewTextBoxColumn.Name = "enrollmentDataGridViewTextBoxColumn";
            // 
            // classtimeDataGridViewTextBoxColumn
            // 
            this.classtimeDataGridViewTextBoxColumn.DataPropertyName = "Class_time";
            this.classtimeDataGridViewTextBoxColumn.HeaderText = "Class_time";
            this.classtimeDataGridViewTextBoxColumn.Name = "classtimeDataGridViewTextBoxColumn";
            // 
            // professoridDataGridViewTextBoxColumn
            // 
            this.professoridDataGridViewTextBoxColumn.DataPropertyName = "Professor_id";
            this.professoridDataGridViewTextBoxColumn.HeaderText = "Professor_id";
            this.professoridDataGridViewTextBoxColumn.Name = "professoridDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            // 
            // semesterYearDataGridViewTextBoxColumn
            // 
            this.semesterYearDataGridViewTextBoxColumn.DataPropertyName = "Semester_Year";
            this.semesterYearDataGridViewTextBoxColumn.HeaderText = "Semester_Year";
            this.semesterYearDataGridViewTextBoxColumn.Name = "semesterYearDataGridViewTextBoxColumn";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(GradingSystem.Class);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxProfessor);
            this.groupBox1.Controls.Add(this.btnAddClass);
            this.groupBox1.Controls.Add(this.txtMaxEnroll);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxSemesters);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxCourses);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Professor";
            // 
            // cbxProfessor
            // 
            this.cbxProfessor.DataSource = this.professorBindingSource;
            this.cbxProfessor.DisplayMember = "First_name";
            this.cbxProfessor.FormattingEnabled = true;
            this.cbxProfessor.Location = new System.Drawing.Point(335, 100);
            this.cbxProfessor.Name = "cbxProfessor";
            this.cbxProfessor.Size = new System.Drawing.Size(121, 21);
            this.cbxProfessor.TabIndex = 7;
            this.cbxProfessor.ValueMember = "Professor_id";
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(GradingSystem.Professor);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(489, 117);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 6;
            this.btnAddClass.Text = "Add";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // txtMaxEnroll
            // 
            this.txtMaxEnroll.Location = new System.Drawing.Point(114, 100);
            this.txtMaxEnroll.Name = "txtMaxEnroll";
            this.txtMaxEnroll.Size = new System.Drawing.Size(121, 20);
            this.txtMaxEnroll.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max. Enroll.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semester";
            // 
            // cbxSemesters
            // 
            this.cbxSemesters.DataSource = this.semesterBindingSource;
            this.cbxSemesters.DisplayMember = "Semester_name";
            this.cbxSemesters.FormattingEnabled = true;
            this.cbxSemesters.Location = new System.Drawing.Point(335, 49);
            this.cbxSemesters.Name = "cbxSemesters";
            this.cbxSemesters.Size = new System.Drawing.Size(121, 21);
            this.cbxSemesters.TabIndex = 2;
            this.cbxSemesters.ValueMember = "Semester_code";
            // 
            // semesterBindingSource
            // 
            this.semesterBindingSource.DataSource = typeof(GradingSystem.Semester);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course";
            // 
            // cbxCourses
            // 
            this.cbxCourses.DataSource = this.courseBindingSource;
            this.cbxCourses.DisplayMember = "Course_name";
            this.cbxCourses.FormattingEnabled = true;
            this.cbxCourses.Location = new System.Drawing.Point(114, 49);
            this.cbxCourses.Name = "cbxCourses";
            this.cbxCourses.Size = new System.Drawing.Size(121, 21);
            this.cbxCourses.TabIndex = 0;
            this.cbxCourses.ValueMember = "Course_code";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(GradingSystem.Course);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(6, 127);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Visible = false;
            // 
            // FrmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 395);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClasses";
            this.Text = "FrmClasses";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSemesters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCourses;
        private System.Windows.Forms.TextBox txtMaxEnroll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource semesterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxenrollmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn classtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProfessor;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.Label lblMsg;
    }
}