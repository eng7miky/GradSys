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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            cbxLoginName.DataSource = ProfessorBusinessLogic.selectAll();
        }

        private void cbxLoginName_SelectedIndexChanged(object sender, EventArgs e)
        {
                btnLogIn.Enabled = cbxLoginName.SelectedIndex > 0;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Professor p= ProfessorBusinessLogic.getProfessor(cbxLoginName.Text, textBox1.Text);
           int x = 0;
           if (p != null)
           {
               new FrmMain().Show();
               this.Hide();
           }
                

        }
    }
}
