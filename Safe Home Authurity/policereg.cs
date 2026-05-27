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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Safe_Home_Authurity
{
    public partial class policereg : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public policereg()
        {
            InitializeComponent();
            string[] policerank = new string[8];

            policerank[0] = "IGP";
            policerank[1] = "DIG";
            policerank[2] = "SP";
            policerank[3] = "ASP";
            policerank[4] = "Inspector";
            policerank[5] = "SI";
            policerank[6] = "ASI";
            policerank[7] = "Constable";
            policerankbox.DataSource = policerank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (textBox1.Text == "" || textBox2.Text == "" || policerankbox.Text == "")
            {
                MessageBox.Show("Please enter Information.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Open the connection
                connect.Open();

                // SQL Insert Query
                string query = "INSERT INTO police (p_id, p_name, jobtitle) VALUES (@UserId, @Password, @Jobtitle)";


                // Create SQL Command
                SqlCommand cmd = new SqlCommand(query, connect);

                // Set values from textboxes
                cmd.Parameters.AddWithValue("@UserId", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                cmd.Parameters.AddWithValue("@Jobtitle", policerankbox.Text);



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

        private void button2_Click(object sender, EventArgs e)
        {
            policelogin plog = new policelogin();
            plog.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
