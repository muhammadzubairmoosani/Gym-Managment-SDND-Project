using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace gymProject
{
    class viewMembersDetail
    {
        string userId;
        string[] lines = File.ReadAllLines("membersDetail.txt");
        internal void onLoad(DataGridView dataGrid)
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("ID");
            DataColumn dc2 = new DataColumn("Full Name");
            DataColumn dc3 = new DataColumn("CNIC");
            DataColumn dc4 = new DataColumn("Email");
            DataColumn dc5 = new DataColumn("Age");
            DataColumn dc6 = new DataColumn("Mobile");
            DataColumn dc7 = new DataColumn("Address");
            DataColumn dc8 = new DataColumn("Gender");
            DataColumn dc9 = new DataColumn("Day");
            DataColumn dc10 = new DataColumn("Month and Date");
            DataColumn dc11 = new DataColumn("Year");
            DataColumn dc12 = new DataColumn("Total Amount");
            DataColumn dc13 = new DataColumn("MemberShip Duration");
            DataColumn dc14 = new DataColumn(" ");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            dt.Columns.Add(dc8);
            dt.Columns.Add(dc9);
            dt.Columns.Add(dc10);
            dt.Columns.Add(dc11);
            dt.Columns.Add(dc12);
            dt.Columns.Add(dc13);
            dt.Columns.Add(dc14);
            dataGrid.DataSource = dt;

            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dt.Rows.Add(row);
            }
        }

        internal void search(Control searchValue, DataGridView dataGrid)
        {
            dataGrid.ClearSelection();
            if (searchValue.Text != "")
            {
                bool flag = true;
                for (int i = 0; i < dataGrid.RowCount - 1; i++)
                {
                    for (int j = 0; j <= 11; j++)
                    {
                        if (dataGrid.Rows[i].Cells[j].Value.ToString().Equals(searchValue.Text.ToLower()))
                        {
                            for (int k = 0; k < 13; k++)
                            {
                                dataGrid.Rows[i].Cells[k].Selected = true;
                            }
                            flag = false;
                            userId = dataGrid.Rows[i].Cells[0].Value.ToString();
                        }
                    }
                }
                if (flag)
                {
                    MessageBox.Show("Member Not Fount!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill-Up Search Field!");
                searchValue.Focus();
            }
        }

        internal void deleteRecord(DataGridView dataGrid)
        {
            bool flag = false;
            for (int i = 0; i < dataGrid.RowCount - 1; i++)
            {
                if (dataGrid.Rows[i].Cells[0].Value.ToString().Equals(userId))
                {
                    dataGrid.Rows.RemoveAt(dataGrid.Rows[i].Index);
                    MessageBox.Show("Delete Record Successfully!");
                    flag = !flag;
                }
            }
            if (flag)
            {
                using (StreamWriter write = new StreamWriter("membersDetail.txt"))
                {
                    for (int i = 0; i < dataGrid.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGrid.ColumnCount; j++)
                        {
                            write.Write(dataGrid.Rows[i].Cells[j].Value.ToString() + ", ");
                        }
                        write.WriteLine();
                    }
                }
            }
        }

        internal void deleteAllRecord(DataGridView dataGrid)
        {
            while (dataGrid.RowCount > 1)
            {
                dataGrid.Rows.RemoveAt(0);
            }
            using (StreamWriter write = new StreamWriter("membersDetail.txt"))
            {
                write.WriteLine();
            }
            MessageBox.Show("Delete All Records Successfuly!");
        }
    }
}
