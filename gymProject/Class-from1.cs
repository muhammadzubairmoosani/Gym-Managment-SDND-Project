using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace gymProject
{
    class Class_from1
    {
        internal string goCheck(string userName, string password)
        {
            string[] adminDetail = File.ReadAllLines("adminDetail.txt");
            if (userName == "" || password == "")
            {
                MessageBox.Show("both field required!");
                return "";
            }
            else if (adminDetail[0] == userName && adminDetail[1] == password)
            {
                Form2 form2 = new Form2();
                form2.Show();
                return "close";
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                return "";
            }
        }
    }
}
