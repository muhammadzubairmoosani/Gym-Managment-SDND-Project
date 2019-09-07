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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Class_from1 class1 = new Class_from1();
            //string a = class1.goCheck(tbUser.Text.ToLower(), tbPass.Text);
            //if (a == "close") Hide(); 
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUser_Click(object sender, EventArgs e)
        {
            tbUser.Clear();
        }

        private void tbPass_Click_1(object sender, EventArgs e)
        {
            tbPass.Clear();
        }
    }
}
