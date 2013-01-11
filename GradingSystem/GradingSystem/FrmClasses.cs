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
            this.semesterBindingSource.DataSource = typeof(GradingSystem.Semester);
           
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
    }
}
