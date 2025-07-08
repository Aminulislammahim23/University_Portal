using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_Portal.Student;

namespace University_Portal
{
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
            AddUserControl(new status());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
                          // index 0 (default display)
            cmbAcademics.Items.Add("Course & Results");        // index 1
            cmbAcademics.Items.Add("Registration");            // index 2
            cmbAcademics.Items.Add("Drop Application");        // index 3
            cmbAcademics.Items.Add("Offered Courses");         // index 4
            cmbAcademics.Items.Add("My Curriculum");           // index 5
            cmbAcademics.Items.Add("Financials");              // index 6

            cmbAcademics.SelectedIndex = 0; // Set "Academics" as default
        }

        private void AddUserControl(UserControl userControl)
        {
            defPnl.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            defPnl.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void StudentDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmbAcademics_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbAcademics.SelectedIndex == 0)
                //return; // Ignore if "Academics" is selected

            defPnl.Controls.Clear(); // Clear previous user control

            UserControl selectedControl = null;

            switch (cmbAcademics.SelectedItem.ToString())
            {
                case "Course & Results":
                    selectedControl = new CRUControl();
                    break;
                case "Registration":
                    selectedControl = new RegUControl();
                    break;
                case "Drop Application":
                    selectedControl = new DAUControl();
                    break;
                case "Offered Courses":
                    selectedControl = new OCUControl();
                    break;
                case "My Curriculum":
                    selectedControl = new MCUControl();
                    break;
                case "Financials":
                    selectedControl = new FUControl();
                    break;
            }

            if (selectedControl != null)
            {
                selectedControl.Dock = DockStyle.Fill;
                defPnl.Controls.Add(selectedControl);
            }
           
        }

        private void CandRlbl_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {

        }

        private void Reglbl_Click(object sender, EventArgs e)
        {

        }

        private void GradeRlbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddUserControl(new status());
        }





    }
}
