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
using Microsoft.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Safe_Home_Authurity
{
    public partial class ownerreg : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        public ownerreg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please enter Information.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Open the connection
                connect.Open();

                // SQL Insert Query
                string query = "INSERT INTO owner (o_id, o_pass, o_name, o_mobile) VALUES (@UserId, @Password, @UserName, @MobileNo)";


                // Create SQL Command
                SqlCommand cmd = new SqlCommand(query, connect);

                // Set values from textboxes
                cmd.Parameters.AddWithValue("@UserId", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                cmd.Parameters.AddWithValue("@UserName", textBox3.Text);
                cmd.Parameters.AddWithValue("@MobileNo", textBox4.Text);


                // Execute the command
                int result = cmd.ExecuteNonQuery();

                // Show success message
                if (result > 0)
                {
                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Close the connection
                connect.Close();
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ownerlogin form3 = new ownerlogin();
            form3.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
