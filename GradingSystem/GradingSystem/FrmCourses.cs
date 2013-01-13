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
    public partial class FrmCourses : Form
    {
        private FrmMain mainFrm;
        public FrmCourses(FrmMain mainForm)
        {
            InitializeComponent();
            this.mainFrm = mainForm;

            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource =CourseBusinessLogic.selectAll();
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = ProfessorBusinessLogic.selectAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainFrm.Show();
            this.Hide();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int x = 0;
        }
    }
}
