using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Safe_Home_Authurity
{
    public partial class buildingmanagement : Form
    {

        string connectionString = "Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        string BuildingId;
        string UserId;
        public buildingmanagement(string userid, string buildingid)
        {
            InitializeComponent();

            this.UserId = userid;
            this.BuildingId = buildingid;
        }

        private void buildingmanagement_Load(object sender, EventArgs e)
        {




            SqlConnection con = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();
            //SqlCommand cmd = new SqlCommand("INSERT INTO flat (f_id, f_number,b_id) VALUES (@ID, @NAME , @BID)", con);
            // cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            //cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
            //cmd.Parameters.AddWithValue("@BID", BuildingId);
            //cmd.Parameters.AddWithValue("@b_id", textBox3.Text);
            // cmd.ExecuteNonQuery();
            //con.Close();

            //MessageBox.Show("Successfully inserted!");
            //Datagrid show
            SqlCommand cmd1 = new SqlCommand(" select * from flat WHERE b_id=@BID", con);
            cmd1.Parameters.AddWithValue("@BID", BuildingId);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            //Fill refresh rows(insert kore or edit kore)
            da.Fill(dt);
            dataGridView1.DataSource = dt;




        }








        private void load_Click(object sender, EventArgs e)
        {





            string query = @"SELECT * FROM own WHERE o_id=@UID and b_id=@bid ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UID", UserId);
                    cmd.Parameters.AddWithValue("@bid", BuildingId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO flat (f_id , f_number,b_id) VALUES (@ID, @NAME , @BID)", con);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@BID", BuildingId);
            //cmd.Parameters.AddWithValue("@b_id", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully inserted!");
            //Datagrid show
            SqlCommand cmd1 = new SqlCommand(" select * from flat WHERE b_id=@BID", con);
            cmd1.Parameters.AddWithValue("@BID", BuildingId);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            //Fill refresh rows(insert kore or edit kore)
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

            SqlCommand cmd = new SqlCommand("UPDATE flat SET f_number = @NAME  WHERE f_id= @ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
            //cmd.Parameters.AddWithValue("@ID", BuildingId);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Record updated successfully!");
            }
            else
            {
                MessageBox.Show("Update failed. Record not found.");
            }
            //Datagrid show
            SqlCommand cmd1 = new SqlCommand(" select * from flat WHERE b_id=@BID", con);
            cmd1.Parameters.AddWithValue("@BID", BuildingId);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            //Fill refresh rows(insert kore or edit kore)
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE  FROM flat WHERE f_id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);

            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Deleted successfully!");
            }
            else
            {
                MessageBox.Show("Delete failed. Record not found.");
            }
            //Datagrid show
            SqlCommand cmd1 = new SqlCommand(" select * from flat WHERE b_id=@BID", con);
            cmd1.Parameters.AddWithValue("@BID", BuildingId);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            //Fill refresh rows(insert kore or edit kore)
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ownerdashboard o2 = new ownerdashboard(UserId);
            o2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
