using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementByCSharp
{
    public class Student
    {
        public Student()
        {
        }

        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string faculty { get; set; }
        public string SWEN501 { get; set; }
        public string SWEN502 { get; set; }
        public string SWEN504 { get; set; }
        public string SWEN589 { get; set; }

        public Student(int id, string name, string gender, string mobile, string email, string faculty, string sWEN501, string sWEN502, string sWEN504, string sWEN589)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.mobile = mobile;
            this.email = email;
            this.faculty = faculty;
            this.SWEN501 = sWEN501;
            this.SWEN502 = sWEN502;
            this.SWEN504 = sWEN504;
            this.SWEN589 = sWEN589;
        }
    }
}
