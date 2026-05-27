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
    public partial class buildingreg : Form
    {

        string userid;

        SqlConnection connect = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public buildingreg(string userid)
        {
            this.userid = userid;
            InitializeComponent();
        }

        private void buildingreg_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            ownerdashboard f1 = new ownerdashboard(userid);
            f1.Show();
        }

        private void registerbutton1_Click(object sender, EventArgs e)
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
                string query = "INSERT INTO own (b_id, b_name, city, sector,o_id) VALUES (@bId, @bname, @city, @sector,@Userid)";


                // Create SQL Command
                SqlCommand cmd = new SqlCommand(query, connect);

                // Set values from textboxes
                cmd.Parameters.AddWithValue("bId", textBox1.Text);
                cmd.Parameters.AddWithValue("@bname", textBox2.Text);
                cmd.Parameters.AddWithValue("city", textBox3.Text);
                cmd.Parameters.AddWithValue("@sector", textBox4.Text);
                cmd.Parameters.AddWithValue("@userid", userid);


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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
