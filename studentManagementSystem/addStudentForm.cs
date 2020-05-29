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
    public partial class addStudentForm : Form
    {
        //filepath for saving the image.
        string filepath;
        //create the sqlconnection
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-0Q2H04V;Initial Catalog=student_db;Integrated Security=True");
        public addStudentForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Open();

            //calculate the age
            DateTime birthdate;
            birthdate = Convert.ToDateTime(dateTimePicker1.Text);
            int age = DateTime.Now.Year - birthdate.Year;

            if (!(age >= 10 && age <= 100))
            {
                MessageBox.Show("Age must be 10 and 100");
            }
            else { 

                //textboxes and radiobutton can not null we check this
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (!(radioButton1.Checked) && (!(radioButton2.Checked))) || (filepath == ""))
                {
                 MessageBox.Show("Empty Fields.");
                }
                else
                {
                    //create the query
                    SqlCommand add = new SqlCommand("INSERT INTO student(Std_Name,Std_Surname,Std_Birthdate," +
                        "Std_Gender,Std_Phone,Std_Adress,Std_Picture)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", db);
                    //we use trim because in the student table std_name is nvarchar(30). your name can be 7 character 
                    //we delete the "" space characters using the trim.
                    add.Parameters.AddWithValue("@p1", textBox1.Text.Trim());
                    add.Parameters.AddWithValue("@p2", textBox2.Text.Trim());
                    add.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
  
                    if (radioButton1.Checked)
                    {
                        add.Parameters.AddWithValue("@p4", 1);
                    }
                    else
                    {
                        add.Parameters.AddWithValue("@p4", 0);
                    }
                    add.Parameters.AddWithValue("@p5", textBox3.Text.Trim());
                    add.Parameters.AddWithValue("@p6", textBox4.Text.Trim());
                    add.Parameters.AddWithValue("@p7", filepath);



                    add.ExecuteNonQuery();
                
                    MessageBox.Show("New Student Added.");
            }
            }
            db.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            filepath = openFileDialog1.FileName;
        }
    }
}
