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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        viewMembersDetail class1 = new viewMembersDetail();

        private void Form4_Load(object sender, EventArgs e)
        {
            class1.onLoad(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            class1.search(tbSearch, dataGridView1);
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            class1.deleteRecord(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            class1.deleteAllRecord(dataGridView1);
        }
    }
}
