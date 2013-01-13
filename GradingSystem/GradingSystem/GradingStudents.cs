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
    public partial class GradingStudents : Form
    {

        public GradingStudents()
        {
            InitializeComponent();
            // dataGridView1.DataSource = 
            //List<Class> classes = ClassBusinessLogic.selectAll();
            //foreach (Class item in classes)
            //{
            dataGridView1.Visible = false;
            cbxCourses.DataSource = ClassBusinessLogic.selectAll();
            courseBindingSource.DataSource = CourseBusinessLogic.selectAll();
            studentBindingSource.DataSource = StudentBusinessLogic.selectAll();
            cbxSemester.DataSource = Semester_YearBusinessLogic.selectAll();
            //}
         //   dataGridView1.DataSource = EnrollmentBusinessLogic.getEnrollmentsOFClass(cCode,semesterId);
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            if (cbxCourses.SelectedValue != null && cbxSemester.SelectedValue != null)
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = EnrollmentBusinessLogic.getStudentsGradesOFClass(int.Parse(cbxCourses.SelectedValue.ToString()), int.Parse(cbxSemester.SelectedValue.ToString()));
            }
        }

    }
}
