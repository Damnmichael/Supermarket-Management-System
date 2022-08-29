using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            getData();
        }
        int OverallSum = 0;
        private void AddTb_Click(object sender, EventArgs e)
        {
            if (DateTb.Text == "" || ItemTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Fill in all fields");
            }
            else
            {
                int ProdTotal = Convert.ToInt32(PriceTb.Text) * Convert.ToInt32(QtyTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(CatDGV);
                newRow.Cells[0].Value = DateTb.Text;
                newRow.Cells[1].Value = ItemTb.Text;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = PriceTb.Text;
                newRow.Cells[4].Value = Convert.ToInt32(PriceTb.Text) * Convert.ToInt32(QtyTb.Text);
                CatDGV.Rows.Add(newRow);
                OverallSum = OverallSum + ProdTotal;

                Amount.Text = "GHS " + OverallSum;
            }
        }

        private void PrintTb_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (DateTb.Text == "" || ItemTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Please fill in all required information");
            }
            else
            {
                try
                {
                    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Michael Gafah\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");

                    Con.Open();
                    string query = "insert into ReceiptTbl values(" + DateTb.Text + ", '" + ItemTb.Text + "', '" + QtyTb.Text + "', '" + PriceTb.Text + "', '" + OverallSum + "')";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Receipt recorded successfully");
                    Con.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void getData()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Michael Gafah\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");

            Con.Open();
            string query = "select * from ReceiptTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            Receipt.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Shoprite Inventory System", new Font("JetBrains Mono", 25, FontStyle.Bold), Brushes.Red, new Point(Top));
            e.Graphics.DrawString("Date: " + Receipt.SelectedRows[0].Cells[0].Value.ToString(), new Font("JetBrains Mono", 15, FontStyle.Bold), Brushes.Black, new Point(30, 70));
            e.Graphics.DrawString("Item: " + Receipt.SelectedRows[0].Cells[1].Value.ToString(), new Font("JetBrains Mono", 15, FontStyle.Bold), Brushes.Black, new Point(30, 100));
            e.Graphics.DrawString("Quantity: " + Receipt.SelectedRows[0].Cells[2].Value.ToString(), new Font("JetBrains Mono", 15, FontStyle.Bold), Brushes.Black, new Point(30, 130));
            e.Graphics.DrawString("Price: " + Receipt.SelectedRows[0].Cells[3].Value.ToString() + " cedis", new Font("JetBrains Mono", 15, FontStyle.Bold), Brushes.Black, new Point(30, 160));
            e.Graphics.DrawString("Total: " + Receipt.SelectedRows[0].Cells[4].Value.ToString() + " cedis", new Font("JetBrains Mono", 15, FontStyle.Bold), Brushes.Black, new Point(30, 160));
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
