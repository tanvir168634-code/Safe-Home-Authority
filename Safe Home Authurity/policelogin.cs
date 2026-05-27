using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safe_Home_Authurity
{
    public partial class policelogin : Form
    {
        public policelogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve user input from text boxes
            string userId = textBox1.Text;
            string userName = textBox2.Text;

            // Step 2: Validate input
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Please enter both Id and Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Step 3: Define the connection string
            string connectionString = "Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            // Step 4: Define the SQL query
            // Using COLLATE to make the Name case-sensitive
            string query = "SELECT COUNT(*) FROM police WHERE p_id = @Id AND p_name COLLATE SQL_Latin1_General_CP1_CS_AS = @Name";

            // Step 5: Establish SQL connection and command
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Step 6: Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@Id", userId);
                    command.Parameters.AddWithValue("@Name", userName);

                    // Step 7: Open the connection
                    connection.Open();

                    // Step 8: Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // Step 9: Process the result
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Hide the current form and show Form3
                        // this.Hide();
                        // Form3 f3 = new Form3(int.Parse(userId));
                        //f3.Show();
                        policedashboard policedash = new policedashboard();
                        policedash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Id or Name.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    //HEllo
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Please fill all blank", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {


                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            policereg preg = new policereg();
            preg.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void policelogin_Load(object sender, EventArgs e)
        {

        }
    }
}
