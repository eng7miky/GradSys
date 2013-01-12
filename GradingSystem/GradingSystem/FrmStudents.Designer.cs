namespace GradingSystem
{
    partial class FrmStudents
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
            this.dgridStudents = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deptnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.studRegisterBtn = new System.Windows.Forms.Button();
            this.studViewEditBtn = new System.Windows.Forms.Button();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.registrationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgridStudents
            // 
            this.dgridStudents.AllowUserToDeleteRows = false;
            this.dgridStudents.AutoGenerateColumns = false;
            this.dgridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.deptnoDataGridViewTextBoxColumn});
            this.dgridStudents.DataSource = this.studentBindingSource;
            this.dgridStudents.Location = new System.Drawing.Point(3, 19);
            this.dgridStudents.Name = "dgridStudents";
            this.dgridStudents.Size = new System.Drawing.Size(663, 168);
            this.dgridStudents.TabIndex = 0;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "First_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // deptnoDataGridViewTextBoxColumn
            // 
            this.deptnoDataGridViewTextBoxColumn.DataPropertyName = "Dept_no";
            this.deptnoDataGridViewTextBoxColumn.DataSource = this.departmentBindingSource;
            this.deptnoDataGridViewTextBoxColumn.DisplayMember = "Dept_name";
            this.deptnoDataGridViewTextBoxColumn.HeaderText = "Department";
            this.deptnoDataGridViewTextBoxColumn.Name = "deptnoDataGridViewTextBoxColumn";
            this.deptnoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deptnoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deptnoDataGridViewTextBoxColumn.ValueMember = "Dept_no";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(GradingSystem.Department);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(GradingSystem.Student);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(925, 255);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // studRegisterBtn
            // 
            this.studRegisterBtn.Location = new System.Drawing.Point(19, 19);
            this.studRegisterBtn.Name = "studRegisterBtn";
            this.studRegisterBtn.Size = new System.Drawing.Size(119, 54);
            this.studRegisterBtn.TabIndex = 3;
            this.studRegisterBtn.Text = "Register";
            this.studRegisterBtn.UseVisualStyleBackColor = true;
            this.studRegisterBtn.Click += new System.EventHandler(this.studRegisterBtn_Click);
            // 
            // studViewEditBtn
            // 
            this.studViewEditBtn.Location = new System.Drawing.Point(19, 96);
            this.studViewEditBtn.Name = "studViewEditBtn";
            this.studViewEditBtn.Size = new System.Drawing.Size(119, 54);
            this.studViewEditBtn.TabIndex = 4;
            this.studViewEditBtn.Text = "View and Edit";
            this.studViewEditBtn.UseVisualStyleBackColor = true;
            // 
            // registrationPanel
            // 
            this.registrationPanel.Controls.Add(this.dgridStudents);
            this.registrationPanel.Location = new System.Drawing.Point(12, 12);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(683, 299);
            this.registrationPanel.TabIndex = 5;
            this.registrationPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studRegisterBtn);
            this.panel1.Controls.Add(this.studViewEditBtn);
            this.panel1.Location = new System.Drawing.Point(701, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 299);
            this.panel1.TabIndex = 6;
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registrationPanel);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmStudents";
            this.Text = "FrmStudents";
            this.Load += new System.EventHandler(this.FrmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.registrationPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn deptnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgridStudents;
        private System.Windows.Forms.Button studRegisterBtn;
        private System.Windows.Forms.Button studViewEditBtn;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.Panel panel1;
    }
}