using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GradingSystem
{
    public partial class FrmCourses : Form
    {
        private FrmMain mainFrm;
        public FrmCourses(FrmMain mainForm)
        {
            InitializeComponent();
            this.mainFrm = mainForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainFrm.Show();
            this.Hide();
        }
    }
}
