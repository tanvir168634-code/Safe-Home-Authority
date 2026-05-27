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
    public partial class worker : Form
    {
        string Userid;
        public worker(string userid)
        {
            InitializeComponent();
            this.Userid = userid;
        }

        private void worker_Load(object sender, EventArgs e)
        {

        }








        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show(
                    "Please insert all required information!",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;   
            }
            //this is

            SqlConnection con = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO workers (w_id,w_name,w_number,city,sector,f_id) VALUES (@WID, @WNAME,@WNUM,@CITY,@SECTOR,@FID)", con);
            cmd.Parameters.AddWithValue("@WID", textBox1.Text);
            cmd.Parameters.AddWithValue("@WNAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@WNUM", textBox6.Text);
            cmd.Parameters.AddWithValue("@CITY", textBox3.Text);
            cmd.Parameters.AddWithValue("@SECTOR", textBox4.Text);
            cmd.Parameters.AddWithValue("@FID", textBox5.Text);
            //cmd.Parameters.AddWithValue("@FID", int.Parse(textBox5.Text));

            //cmd.Parameters.AddWithValue("@b_id", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully inserted!");


            SqlCommand cmd1 = new SqlCommand(@"
               SELECT 

                 w.w_id AS [Worker ID],
                 w.w_name AS [Worker Name],
                 w.city AS [Worker City],
                 w.sector AS [Worker Sector],
                 w.w_number AS [Worker Mobile No],
                    w.f_id AS [Flat ID]

            FROM workers w
            JOIN flat f ON w.f_id = f.f_id
            JOIN own e ON f.b_id = e.b_id
            WHERE e.o_id = @OwnerId", con);
            cmd1.Parameters.AddWithValue("@OwnerId", Userid);

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            //Fill refresh rows(insert kore or edit kore)
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show(
                    "Please insert all required information!",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;   
            }
            //this 
            SqlConnection con = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE workers SET w_id=@WID, w_name=@WNAME,w_number=@WNUM ,city=@CITY,sector=@SECTOR,f_id=@FID WHERE w_id= @WID", con);
            cmd.Parameters.AddWithValue("@WID", textBox1.Text);
            cmd.Parameters.AddWithValue("@WNAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@WNUM", textBox6.Text);
            cmd.Parameters.AddWithValue("@CITY", textBox3.Text);
            cmd.Parameters.AddWithValue("@SECTOR", textBox4.Text);
            cmd.Parameters.AddWithValue("@FID", textBox5.Text);


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
            SqlCommand cmd1 = new SqlCommand(@"SELECT
              
                 w.w_id AS [Worker ID],
                 w.w_name AS [Worker Name],
                 w.city AS [Worker City],
                 w.sector AS [Worker Sector],
                 w.w_number AS [Worker Mobile No],
                    w.f_id AS [Flat ID]




            FROM workers w
            JOIN flat f ON w.f_id = f.f_id
            JOIN own e ON f.b_id = e.b_id
            WHERE e.o_id = @OwnerId", con);
            cmd1.Parameters.AddWithValue("@OwnerId", Userid);

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            //Fill refresh rows(insert kore or edit kore)
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||string.IsNullOrWhiteSpace(textBox2.Text) ||string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||string.IsNullOrWhiteSpace(textBox5.Text) ||string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show(
                    "Please insert all required information!",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;   
            }
            SqlConnection con = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM workers WHERE w_id = @WID", con);
            cmd.Parameters.AddWithValue("@WID", textBox1.Text);

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
            SqlCommand cmd1 = new SqlCommand(@"
               SELECT 

                 w.w_id AS [Worker ID],
                 w.w_name AS [Worker Name],
                 w.city AS [Worker City],
                 w.sector AS [Worker Sector],
                 w.w_number AS [Worker Mobile No],
                 w.f_id AS [Flat ID]



            FROM workers w
            JOIN flat f ON w.f_id = f.f_id
            JOIN own e ON f.b_id = e.b_id
            WHERE e.o_id = @OwnerId", con);
            cmd1.Parameters.AddWithValue("@OwnerId", Userid);

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            //Fill refresh rows(insert kore or edit kore)
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ownerdashboard o1 = new ownerdashboard(Userid);
            o1.Show();
            this.Hide();
        }
    }
}
