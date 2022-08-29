using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Data;

namespace Supermarket_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PassTb.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Michael Gafah\Documents\smarketdb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string username = UnameTb.Text;
            string password = PassTb.Text;

            try
            {
                string query = "select * from UsersTbl where UserName = '" + UnameTb.Text + "' AND PassWord = '" + PassTb.Text + "' AND Role = '" + RoleCb.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0 && RoleCb.Text == "ADMIN")
                {
                    username = UnameTb.Text;
                    password = PassTb.Text;
                    ProductForm log = new ProductForm();
                    this.Hide();
                    log.Show();
                }
                else if (dtable.Rows.Count > 0 && RoleCb.Text == "ATTENDANT")
                {
                    username = UnameTb.Text;
                    password = PassTb.Text;
                    Attendants log = new Attendants();
                    this.Hide();
                    log.Show();
                }
                else
                {
                    MessageBox.Show("Invalid user credentials");
                    UnameTb.Text = "";
                    PassTb.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Invalid user credentials");
            }
            finally
            {
                Con.Close();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }
    }
}