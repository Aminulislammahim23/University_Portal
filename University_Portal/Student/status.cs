using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Portal.Student
{
    public partial class status : UserControl
    {
        public status()
        {
            InitializeComponent();
            //AddUserControl(new status());
        }

        private void AddUserControl(UserControl userControl)
        {
            pnlGrades.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlGrades.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

        }

        private void btnIdentity_Click(object sender, EventArgs e)
        {

        }

        private void btnCovid_Click(object sender, EventArgs e)
        {

        }

        private void status_Load(object sender, EventArgs e)
        {

        }

        



    }
}
