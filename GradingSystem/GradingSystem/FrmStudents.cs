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
    public partial class FrmStudents : Form
    {
        private FrmMain mainForm;
        public FrmStudents(FrmMain mainForm)
        {
            InitializeComponent();
            this.departmentBindingSource.DataSource = DepartmentBusinessLogic.selectAll();
            this.studentBindingSource.DataSource = StudentBusinessLogic.selectAll();
            this.mainForm = mainForm;
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainForm.Show();
            this.Hide();
        }
    }
}
