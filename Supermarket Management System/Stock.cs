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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void CatIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transaction Trans = new Transaction();
            this.Hide();
            Trans.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AttendantsTill Tills = new AttendantsTill();
            this.Hide();
            Tills.Show();
        }

        private void populate()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Michael Gafah\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");
            Con.Open();
            string query = "select ProdName, ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StockDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void fillcombo()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Michael Gafah\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "catName";
            CatCb.DataSource = dt;
            Con.Close();
        }

        private void AddTb_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Michael Gafah\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");
                Con.Open();
                string query = "insert into ProductTbl values(" + ID.Text + ", '" + ProdName.Text + "', '" + ProdQty.Text + "', '" + ProdPrice.Text + "', '" + CatCb.Text + "' )";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                MessageBox.Show("Product added to stock successfully");
                Con.Close();
                populate();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            populate();
            fillcombo();
        }
    }
}
