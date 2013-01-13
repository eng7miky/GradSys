using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GradingSystem.Business_logic;

namespace GradingSystem
{
    public partial class FrmClasses : Form
    {
        private FrmMain mainForm;
        public FrmClasses(FrmMain mainForm)
        {
            InitializeComponent();
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = ClassBusinessLogic.selectAll();
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = CourseBusinessLogic.selectAll();
            // 
            // semesterBindingSource
            // 
            this.semesterBindingSource.DataSource = Semester_YearBusinessLogic.selectAll();

            // 
            // semesterBindingSource
            // 
            this.cbxProfessor.DataSource = ProfessorBusinessLogic.selectAll();

           
            this.mainForm = mainForm;
        }

        private void dataGridView1_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            int x = 0;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainForm.Show();
            this.Hide();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
           bool isInserted =  ClassBusinessLogic.addClass(int.Parse(cbxCourses.SelectedValue.ToString()),int.Parse(cbxSemesters.SelectedValue.ToString()),int.Parse(txtMaxEnroll.Text),0,DateTime.Now,int.Parse(cbxProfessor.SelectedValue.ToString()));
            if(isInserted){

                lblMsg.Text = "Class inserted successfully";
                lblMsg.Visible = true;
              //  dataGridView1.DataSource=null;
                dataGridView1.DataSource = ClassBusinessLogic.selectAll();
            }
        }
    }
}
