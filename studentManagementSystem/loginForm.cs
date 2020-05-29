using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentManagementSystem
{
    public partial class loginForm : Form
    {
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-0Q2H04V;Initial Catalog=student_db;Integrated Security=True");
        public loginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlCommand query = new SqlCommand("SELECT * FROM [user] where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'",db);
            SqlDataReader run = query.ExecuteReader();
            if (run.Read())
            {
                this.Hide();
                new main().Show();
            }
            else
            {
                MessageBox.Show("Username or Password is not correct. Please try again...");
                textBox1.Text = "";
                textBox2.Text = "";
            }

            db.Close();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
