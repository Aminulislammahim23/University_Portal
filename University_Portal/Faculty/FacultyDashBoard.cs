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
    public partial class FacultyDashBoard : Form
    {
        public FacultyDashBoard()
        {
            InitializeComponent();
        }

        private void FacultyDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
