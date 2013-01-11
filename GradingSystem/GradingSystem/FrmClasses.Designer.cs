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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxEnroll = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semesterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.semesteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.maxenrollmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddClass);
            this.groupBox1.Controls.Add(this.txtMaxEnroll);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semester";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(381, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
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
            // txtMaxEnroll
            // 
            this.txtMaxEnroll.Location = new System.Drawing.Point(114, 100);
            this.txtMaxEnroll.Name = "txtMaxEnroll";
            this.txtMaxEnroll.Size = new System.Drawing.Size(121, 20);
            this.txtMaxEnroll.TabIndex = 5;
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
            this.enrollmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 239);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowDividerDoubleClick += new System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler(this.dataGridView1_RowDividerDoubleClick);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(GradingSystem.Class);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(GradingSystem.Course);
            // 
            // semesterBindingSource
            // 
            this.semesterBindingSource.DataSource = typeof(GradingSystem.Semester);
            // 
            // coursecodeDataGridViewTextBoxColumn
            // 
            this.coursecodeDataGridViewTextBoxColumn.DataPropertyName = "Course_code";
            this.coursecodeDataGridViewTextBoxColumn.DataSource = this.courseBindingSource;
            this.coursecodeDataGridViewTextBoxColumn.DisplayMember = "Course_name";
            this.coursecodeDataGridViewTextBoxColumn.HeaderText = "Course_code";
            this.coursecodeDataGridViewTextBoxColumn.Name = "coursecodeDataGridViewTextBoxColumn";
            this.coursecodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coursecodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.coursecodeDataGridViewTextBoxColumn.ValueMember = "Course_code";
            // 
            // semesteridDataGridViewTextBoxColumn
            // 
            this.semesteridDataGridViewTextBoxColumn.DataPropertyName = "Semester_id";
            this.semesteridDataGridViewTextBoxColumn.DataSource = this.semesterBindingSource;
            this.semesteridDataGridViewTextBoxColumn.DisplayMember = "Semester_name";
            this.semesteridDataGridViewTextBoxColumn.HeaderText = "Semester_id";
            this.semesteridDataGridViewTextBoxColumn.Name = "semesteridDataGridViewTextBoxColumn";
            this.semesteridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.semesteridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.semesteridDataGridViewTextBoxColumn.ValueMember = "Semester_code";
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
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(489, 117);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 6;
            this.btnAddClass.Text = "Add";
            this.btnAddClass.UseVisualStyleBackColor = true;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtMaxEnroll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn coursecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn semesteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource semesterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxenrollmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.Button btnAddClass;
    }
}