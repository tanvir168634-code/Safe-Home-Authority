using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Reflection;

namespace Safe_Home_Authurity
{
    public partial class ownerdashboard : Form
    {

        string UserId;


        string connectionString = "Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public ownerdashboard(string userid)
        {
            this.UserId = userid;
            InitializeComponent();
        }


        private void button(object sender, EventArgs e)
        {
            string buildingid = textBox1.Text;



            // Step 2: Validate input
            if (string.IsNullOrWhiteSpace(buildingid))
            {

                MessageBox.Show("Please enter Building Id ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Step 3: Define the connection string
            // string connectionString = "Data Source=ANAN-LAPTOP\\SQLEXPRESS;Initial Catalog=shauthority;Integrated Security=True;Trust Server Certificate=True";
            // Step 4: Define the SQL query
            // Using COLLATE to make the Name case-sensitive
            string query = "SELECT COUNT(*) FROM own WHERE b_id = @bId AND o_id  = @oid";

            // Step 5: Establish SQL connection and command
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Step 6: Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@bId", buildingid);
                    command.Parameters.AddWithValue("@oid", UserId);

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

                        buildingmanagement b1 = new buildingmanagement(UserId, buildingid);
                        b1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Building Id .", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    //HEllo
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Please fill all blank", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {


                    }
                }
            }

        }

        private void ownerdashboard_Load(object sender, EventArgs e)
        {


            string query = @"
        SELECT 
            o.o_id[Owner ID],
            o.o_name [Name], 
            b.b_id [Building ID], 
            b.b_name [Building Name], 
            b.city [Building Address City], 
            b.sector [Building Address Sector]
        FROM 
            owner o
        INNER JOIN 
            own b ON o.o_id = b.o_id
        WHERE 
            o.o_id = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Step 6: Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@ID", UserId);

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }




        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerbutton1_Click(object sender, EventArgs e)
        {

            buildingreg buildingreg = new buildingreg(UserId);
            buildingreg.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            Developer o1 = new Developer(UserId);
            o1.Show();





        }

        private void showallbutton2_Click(object sender, EventArgs e)
        {

            ownershowall o1 = new ownershowall(UserId);
            o1.Show();
        }

        private void addtanent_Click(object sender, EventArgs e)
        {
            tanentmanagement tanent = new tanentmanagement(UserId);
            tanent.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Developer o1 = new Developer(UserId);
            o1.Show();
        }

        private void wokerbutton1_Click(object sender, EventArgs e)
        {
            worker w1 = new worker(UserId);

            w1.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Logout successful!", "Success", MessageBoxButtons.OK);
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
