using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementByCSharp
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private string getAdminPassword(string username)
        {
            string sql = "select * from manage where user_name = @username";
            Dao dao = new Dao();
            string localpassword = null;
            var pparams = new List<MySqlParameter>
            {
                new MySqlParameter("@username", username.ToLower())
            };

            MySqlDataReader reader = dao.read(sql, pparams);
            
                if (reader.Read())
                {
                    username = reader.GetString(0);
                    localpassword = reader.GetString(1);                                   
                }                         
            reader.Close();
            reader.Dispose();
            return localpassword;
        }
    

        private bool login()
        {
            
            if (adminBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Username or Password cannot be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                var pw = getAdminPassword(adminBox.Text);

                if ( passwordBox.Text == pw)
                {
                    return true;
                }
                else 
                {
                    MessageBox.Show("Invalid Username or Password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (login()) 
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
}
