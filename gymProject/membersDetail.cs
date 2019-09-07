using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace gymProject
{
    class membersDetail
    {
        internal void insertData(int UserId, string name, string cnic, string email, string age, string mobile, string address, string gender, string dateTime, int amount, string duration)
        {
            if (name != "" && cnic != "" && age != "" && mobile != "" && address != "" && gender != "" && dateTime != "" && amount != 0 && duration != "")
            {
                using (StreamWriter write = new StreamWriter("membersDetail.txt", true))
                {
                    write.WriteLine(UserId + ", " + name + ", " + cnic + ", " + email + ", " + age + ", " + mobile + ", " + address + ", " + gender + ", " + dateTime + ", " + amount + ", " + duration);
                }
                MessageBox.Show("Record Saved Successfuly!");
            }
            else
            {
                MessageBox.Show("Please Fill-up All Text Fields!");
            }
        }

        internal void clearAllTextFields(TextBox name, TextBox cnic, TextBox email, TextBox age, TextBox mobile, TextBox address, RadioButton radioButton1, DateTimePicker dateAndTime, TextBox amount, ComboBox duration)
        {
            age.Text = ""; cnic.Text = ""; name.Text = ""; email.Text = ""; mobile.Text = ""; amount.Text = ""; address.Text = ""; duration.Text = null; dateAndTime.Text = ""; radioButton1.Checked = true;
        }
    }
}
