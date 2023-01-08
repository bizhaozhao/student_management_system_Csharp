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
    public partial class AddStudentPage : Form
    {
        public AddStudentPage()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" && emailBox.Text == "")
            {
                MessageBox.Show("Must input Student name and email!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "Insert into student(name, gender, mobile, email, faculty, SWEN501, SWEN502, SWEN504, SWEN589) values " +
                                                "(@name,@gender, @mobile, @email, @faculty, @SWEN501, @SWEN502, @SWEN504, @SWEN589)";
                var pparams = new List<MySqlParameter>
                {
                    new MySqlParameter("@name",nameBox.Text),
                    new MySqlParameter("@gender",genderBox.Text),
                    new MySqlParameter("@mobile",mobileBox.Text),
                    new MySqlParameter("@email",emailBox.Text),
                    new MySqlParameter("@faculty",facultyBox.Text),
                    new MySqlParameter("@SWEN501",SWEN501Box.Text),
                    new MySqlParameter("@SWEN502", SWEN501Box.Text),
                    new MySqlParameter("@SWEN504", SWEN501Box.Text),
                    new MySqlParameter("@SWEN589", SWEN501Box.Text)
                    };

                Dao dao = new Dao();
                int i = dao.Execute(sql, pparams);
                if (i > 0)
                {                    
                    MessageBox.Show(nameBox.Text + " has been added Successfully!");
                }
                else
                {
                    MessageBox.Show("Add student Unsuccessfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            genderBox.Text = "";
            mobileBox.Text = "";
            emailBox.Text = "";
            facultyBox.Text = "";
            SWEN501Box.Text = "";
            SWEN502Box.Text = "";
            SWEN504Box.Text = "";
            SWEN589Box.Text = "";
        }
    }
}
