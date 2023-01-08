using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace StudentManagementByCSharp
{
    public partial class MainPage : Form
    {
       
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddStudentPage addStudentPage = new AddStudentPage();
            addStudentPage.Show();
        }

        private void inquireBtn_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Delete!", "Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    string id, name;
                    id = dataGridView1.SelectedCells[0].Value.ToString();
                    name = dataGridView1.SelectedCells[1].Value.ToString();

                    string sql = "delete from student where id ='" + id + "'and name='" + name + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    displayData();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Please select the whole row!");
                    Console.WriteLine(ex.ToString());
                }                
            }
        }

        public void modifyBtn_Click(object sender, EventArgs e)
        {

            try
            {            
                int id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                string name = dataGridView1.SelectedCells[1].Value.ToString();
                string gender = dataGridView1.SelectedCells[2].Value.ToString();
                string mobile = dataGridView1.SelectedCells[3].Value.ToString();
                string email = dataGridView1.SelectedCells[4].Value.ToString();
                string faculty = dataGridView1.SelectedCells[5].Value.ToString();
                string SWEN501 = dataGridView1.SelectedCells[6].Value.ToString();
                string SWEN502 = dataGridView1.SelectedCells[7].Value.ToString();
                string SWEN504 = dataGridView1.SelectedCells[8].Value.ToString();
                string SWEN589 = dataGridView1.SelectedCells[9].Value.ToString();

                Student student = new Student(id, name, gender, mobile, email, faculty, SWEN501, SWEN502, SWEN504, SWEN589);

                ModifyStudentPage modifyStudentPage = new ModifyStudentPage(student);
                modifyStudentPage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select the whole row!");
                Console.WriteLine(ex.ToString());
            }
        }

        private void displayData()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from student";

            Dao dao = new Dao();
            MySqlDataReader reader = dao.read(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string gender = reader.GetString(2);
                    string mobile = reader.GetString(3);
                    string email = reader.GetString(4);
                    string faculty = reader.GetString(5);
                    string SWEN501 = reader.GetString(6);
                    string SWEN502 = reader.GetString(7);
                    string SWEN504 = reader.GetString(8);
                    string SWEN589 = reader.GetString(9);
                    string[] student = { id.ToString(), name, gender, mobile, email, faculty, SWEN501, SWEN502, SWEN504, SWEN589 };     
                    dataGridView1.Rows.Add(student);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            reader.Dispose();
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
