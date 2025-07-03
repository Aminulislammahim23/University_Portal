using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Portal
{
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }

        private void StudentDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
