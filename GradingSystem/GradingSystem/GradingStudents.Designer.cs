﻿namespace GradingSystem
{
    partial class GradingStudents
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
            this.cbxCourses = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectmarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalexamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalmarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradingSysDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradingSysDataSet = new GradingSystem.GradingSysDataSet();
            this.gradingSysDataClassesDataContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewClassStudentsTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentBusinessLogicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSemester = new System.Windows.Forms.ComboBox();
            this.semesterYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semesterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSysDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSysDataClassesDataContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassStudentsTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBusinessLogicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCourses
            // 
            this.cbxCourses.DataSource = this.courseBindingSource;
            this.cbxCourses.DisplayMember = "Course_name";
            this.cbxCourses.FormattingEnabled = true;
            this.cbxCourses.Location = new System.Drawing.Point(106, 12);
            this.cbxCourses.Name = "cbxCourses";
            this.cbxCourses.Size = new System.Drawing.Size(121, 21);
            this.cbxCourses.TabIndex = 0;
            this.cbxCourses.ValueMember = "Course_code";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(GradingSystem.Course);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(GradingSystem.Class);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Courses";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.yearworkDataGridViewTextBoxColumn,
            this.projectmarksDataGridViewTextBoxColumn,
            this.finalexamDataGridViewTextBoxColumn,
            this.totalmarksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentGradesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 162);
            this.dataGridView1.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearworkDataGridViewTextBoxColumn
            // 
            this.yearworkDataGridViewTextBoxColumn.DataPropertyName = "year_work";
            this.yearworkDataGridViewTextBoxColumn.HeaderText = "year_work";
            this.yearworkDataGridViewTextBoxColumn.Name = "yearworkDataGridViewTextBoxColumn";
            // 
            // projectmarksDataGridViewTextBoxColumn
            // 
            this.projectmarksDataGridViewTextBoxColumn.DataPropertyName = "project_marks";
            this.projectmarksDataGridViewTextBoxColumn.HeaderText = "project_marks";
            this.projectmarksDataGridViewTextBoxColumn.Name = "projectmarksDataGridViewTextBoxColumn";
            // 
            // finalexamDataGridViewTextBoxColumn
            // 
            this.finalexamDataGridViewTextBoxColumn.DataPropertyName = "final_exam";
            this.finalexamDataGridViewTextBoxColumn.HeaderText = "final_exam";
            this.finalexamDataGridViewTextBoxColumn.Name = "finalexamDataGridViewTextBoxColumn";
            // 
            // totalmarksDataGridViewTextBoxColumn
            // 
            this.totalmarksDataGridViewTextBoxColumn.DataPropertyName = "total_marks";
            this.totalmarksDataGridViewTextBoxColumn.HeaderText = "total_marks";
            this.totalmarksDataGridViewTextBoxColumn.Name = "totalmarksDataGridViewTextBoxColumn";
            // 
            // studentGradesBindingSource
            // 
            this.studentGradesBindingSource.DataSource = typeof(GradingSystem.DAO.EnrollmentDAO.Student_Grades);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(GradingSystem.Student);
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataSource = typeof(GradingSystem.Enrollment);
            // 
            // gradingSysDataSetBindingSource
            // 
            this.gradingSysDataSetBindingSource.DataSource = this.gradingSysDataSet;
            this.gradingSysDataSetBindingSource.Position = 0;
            // 
            // gradingSysDataSet
            // 
            this.gradingSysDataSet.DataSetName = "GradingSysDataSet";
            this.gradingSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradingSysDataClassesDataContextBindingSource
            // 
            this.gradingSysDataClassesDataContextBindingSource.DataSource = typeof(GradingSystem.GradingSys_DataClassesDataContext);
            // 
            // viewClassStudentsTableAdapterBindingSource
            // 
            this.viewClassStudentsTableAdapterBindingSource.DataSource = typeof(GradingSystem.GradingSysDataSetTableAdapters.View_Class_StudentsTableAdapter);
            // 
            // enrollmentBusinessLogicBindingSource
            // 
            this.enrollmentBusinessLogicBindingSource.DataSource = typeof(GradingSystem.Business_logic.EnrollmentBusinessLogic);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Semester";
            // 
            // cbxSemester
            // 
            this.cbxSemester.DataSource = this.semesterYearBindingSource;
            this.cbxSemester.DisplayMember = "Semester_code";
            this.cbxSemester.FormattingEnabled = true;
            this.cbxSemester.Location = new System.Drawing.Point(375, 12);
            this.cbxSemester.Name = "cbxSemester";
            this.cbxSemester.Size = new System.Drawing.Size(121, 21);
            this.cbxSemester.TabIndex = 3;
            this.cbxSemester.ValueMember = "Semester_id";
            // 
            // semesterYearBindingSource
            // 
            this.semesterYearBindingSource.DataSource = typeof(GradingSystem.Semester_Year);
            // 
            // semesterBindingSource
            // 
            this.semesterBindingSource.DataSource = typeof(GradingSystem.Semester);
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.Location = new System.Drawing.Point(567, 43);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(103, 23);
            this.btnLoadStudents.TabIndex = 5;
            this.btnLoadStudents.Text = "Load Students";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // 
            // GradingStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 262);
            this.Controls.Add(this.btnLoadStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSemester);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCourses);
            this.Name = "GradingStudents";
            this.Text = "GradingStudents";
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSysDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSysDataClassesDataContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassStudentsTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBusinessLogicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gradingSysDataSetBindingSource;
        private GradingSysDataSet gradingSysDataSet;
        private System.Windows.Forms.BindingSource gradingSysDataClassesDataContextBindingSource;
        private System.Windows.Forms.BindingSource viewClassStudentsTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource enrollmentBusinessLogicBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSemester;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.BindingSource semesterBindingSource;
        private System.Windows.Forms.BindingSource semesterYearBindingSource;
        private System.Windows.Forms.BindingSource studentGradesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectmarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalexamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalmarksDataGridViewTextBoxColumn;
    }
}