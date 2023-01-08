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
    public partial class ModifyStudentPage : Form
    {
        int id;

        public ModifyStudentPage()
        {
            InitializeComponent();
        }

        public ModifyStudentPage(Student student)
        {
            InitializeComponent();

            id = student.id;
            nameBox.Text = student.name;
            genderBox.Text = student.gender;
            mobileBox.Text = student.mobile;
            emailBox.Text = student.email;
            facultyBox.Text = student.faculty;
            SWEN501Box.Text = student.SWEN501;
            SWEN502Box.Text = student.SWEN502;
            SWEN504Box.Text = student.SWEN504;
            SWEN589Box.Text = student.SWEN589;
        }

        private void modifyStudentBtn_Click(object sender, EventArgs e)
        {
            string sql = "Update student set name=@name, gender=@gender, mobile=@mobile, email=@email, " +
                "faculty=@faculty, SWEN501=@SWEN501, SWEN502=@SWEN502, SWEN504=@SWEN504, SWEN589=@SWEN589 " +
                " where id = @id";

            var pparams = new List<MySqlParameter>
                { 
                    new MySqlParameter("@id",id),
                    new MySqlParameter("@name",nameBox.Text),
                    new MySqlParameter("@gender",genderBox.Text),
                    new MySqlParameter("@mobile",mobileBox.Text),
                    new MySqlParameter("@email",emailBox.Text),
                    new MySqlParameter("@faculty",facultyBox.Text),
                    new MySqlParameter("@SWEN501",SWEN501Box.Text),
                    new MySqlParameter("@SWEN502", SWEN502Box.Text),
                    new MySqlParameter("@SWEN504", SWEN504Box.Text),
                    new MySqlParameter("@SWEN589", SWEN589Box.Text)
                    };

            if (nameBox.Text == "" || emailBox.Text == "")
            {
                MessageBox.Show("Student name and email can not be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                Dao dao = new Dao();
                int i = dao.Execute(sql, pparams);
                if (i > 0)
                {
                    MessageBox.Show(nameBox.Text + " has been modified!");
                }
                else
                {
                    MessageBox.Show("No data!");
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
