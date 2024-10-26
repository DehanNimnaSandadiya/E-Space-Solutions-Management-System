using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace E_Space_Solutions
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Clear input fields when the form loads
            ClearInputFields();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            {
                string username = txtuname.Text;
                string password = txtpass.Text;

                // Authentication
                if (username == "Admin" && password == "123")
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.Show();
                }

                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void ClearInputFields()
        {
            txtuname.Clear();
            txtpass.Clear();
        }
    }
}
