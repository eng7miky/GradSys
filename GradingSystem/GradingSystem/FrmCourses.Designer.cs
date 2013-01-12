namespace GradingSystem
{
    partial class FrmCourses
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credithoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            
            this.btnBack = new System.Windows.Forms.Button();
            this.courseBusinessLogicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBusinessLogicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coursecodeDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.credithoursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(GradingSystem.Course);
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(GradingSystem.Professor);
            // 
            // coursecodeDataGridViewTextBoxColumn
            // 
            this.coursecodeDataGridViewTextBoxColumn.DataPropertyName = "Course_code";
            this.coursecodeDataGridViewTextBoxColumn.HeaderText = "Course_code";
            this.coursecodeDataGridViewTextBoxColumn.Name = "coursecodeDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "Course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "Course_name";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // credithoursDataGridViewTextBoxColumn
            // 
            this.credithoursDataGridViewTextBoxColumn.DataPropertyName = "Credit_hours";
            this.credithoursDataGridViewTextBoxColumn.HeaderText = "Credit_hours";
            this.credithoursDataGridViewTextBoxColumn.Name = "credithoursDataGridViewTextBoxColumn";
            // 
            // professoridDataGridViewTextBoxColumn
            // 
            this.professoridDataGridViewTextBoxColumn.DataPropertyName = "Professor_id";
            this.professoridDataGridViewTextBoxColumn.DataSource = this.professorBindingSource;
            this.professoridDataGridViewTextBoxColumn.DisplayMember = "First_name";
            this.professoridDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professoridDataGridViewTextBoxColumn.Name = "professoridDataGridViewTextBoxColumn";
            this.professoridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.professoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.professoridDataGridViewTextBoxColumn.ValueMember = "Professor_id";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(365, 212);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // courseBusinessLogicBindingSource
            // 
            this.courseBusinessLogicBindingSource.DataSource = typeof(GradingSystem.Business_logic.CourseBusinessLogic);
            // 
            // FrmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 247);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCourses";
            this.Text = "FrmCourses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBusinessLogicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource courseBusinessLogicBindingSource;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn credithoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn professoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;

    }
}