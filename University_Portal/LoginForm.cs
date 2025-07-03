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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                string sql = "select * from Users where UserID= '" + this.txtID.Text + "' and PasswordHash = '" + this.txtPassword.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);


                if (ds.Tables[0].Rows.Count == 1)
                {
                    var name = ds.Tables[0].Rows[0][1].ToString().ToUpper();   //anony type
                    if (ds.Tables[0].Rows[0][3].ToString() == "admin")
                    {
                        this.Hide();
                        new AdminDashBoard().Show();   //name, this
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString() == "faculty")
                    {
                        this.Hide();
                        new FacultyDashBoard().Show();
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString() == "student")
                    {
                        this.Hide();
                        new StudentDashBoard().Show();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid User!!!");
                }

            }
            catch (Exception ex) {
            
                    
            
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.txtID.Clear();
            this.txtID.Clear();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
