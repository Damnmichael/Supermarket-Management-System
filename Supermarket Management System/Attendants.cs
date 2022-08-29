using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class Attendants : Form
    {
        public Attendants()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
      
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sid.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Sname.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Sage.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Sphone.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Spass.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Michael Gafah\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into AttendantsTbl values('" + Sid.Text + "','" + Sname.Text + "','" + Sage.Text + "','" + Sphone.Text + "', '" + Spass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendant Added Sucessfully");
                Con.Close();
                Con.Close();
                Sid.Text = "";
                Sname.Text = "";
                Sphone.Text = "";
                Spass.Text = "";
                Sage.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sid.Text == "")
                {
                    MessageBox.Show("Select the Seller To Clear");
                }
                else
                {
                    Con.Open();
                    String query = "delete from SellerTbl where AttendantsId="+Sid.Text+"";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Cleared Successfully");
                    Con.Close();
                    Sid.Text = "";
                    Sname.Text = "";
                    Sphone.Text = "";
                    Spass.Text = "";
                    Sage.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sname.Text == "" || Sid.Text == "" || Sage.Text == "" || Sphone.Text == "" || Spass.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    Con.Open();
                    string query = "update SellerTbl set AttendantsName='" + Sname.Text + "',AttendantsAge=" + Sage.Text + ",AttendantsPhone='" + Sphone.Text + "',AttendantsPass='" + Spass.Text + "'where AttendantsId=" + Sid.Text + ";";
                    SqlCommand cmd = new SqlCommand(@query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
                    Con.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CATEGORYFORM form = new CATEGORYFORM();
            this.Hide();
            form.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
