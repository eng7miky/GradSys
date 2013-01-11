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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            new FrmStudents(this).Show();
            this.Hide();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            new FrmCourses(this).Show();
            this.Hide();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            new FrmClasses(this).Show();
            this.Hide();
        }


    }
}
