using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymProject
{
    public partial class Form3 : Form
    {
        int id = 1;
        public Form3()
        {
            InitializeComponent();
        }
        membersDetail addClass = new membersDetail();
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string gender = radioButton1.Checked == true ? "male" : "female";
            int amount = Convert.ToInt32(tbAmount.Text != "" ? tbAmount.Text : "0");
            addClass.insertData(id++, tbName.Text, tbCNIC.Text, tbEmail.Text, tbAge.Text, tbMobile.Text, tbAddress.Text, gender, dateTime.Text, amount, tbDuration.Text);
            addClass.clearAllTextFields(tbName, tbCNIC, tbEmail, tbAge, tbMobile, tbAddress, radioButton1, dateTime, tbAmount, tbDuration);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addClass.clearAllTextFields(tbName, tbCNIC, tbEmail, tbAge, tbMobile, tbAddress, radioButton1, dateTime, tbAmount, tbDuration);
        }
    }
}
