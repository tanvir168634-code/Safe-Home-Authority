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

namespace Safe_Home_Authurity
{
    public partial class tanentmanagement : Form
    {
        string UserId;
        public tanentmanagement(string userid)
        {
            this.UserId = userid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tenant (t_id,t_name,city,sector,f_id) VALUES (@TID, @TNAME,@CITY,@SECTOR,@FID)", con);
            cmd.Parameters.AddWithValue("@TID", textBox1.Text);
            cmd.Parameters.AddWithValue("@TNAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@CITY", textBox3.Text);
            cmd.Parameters.AddWithValue("@SECTOR", textBox4.Text);
            cmd.Parameters.AddWithValue("@FID", textBox5.Text);
            //cmd.Parameters.AddWithValue("@FID", int.Parse(textBox5.Text));

            //cmd.Parameters.AddWithValue("@b_id", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully inserted!");
            //Datagrid show
            SqlCommand cmd1 = new SqlCommand(@"
               SELECT t.*
            FROM tenant t
            JOIN flat f ON t.f_id = f.f_id
            JOIN own e ON f.b_id = e.b_id
            WHERE e.o_id = @OwnerId", con);
            cmd1.Parameters.AddWithValue("@OwnerId", UserId);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            //Fill refresh rows(insert kore or edit kore)
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE tenant SET t_id=@TID, t_name=@TNAME ,city=@CITY,sector=@SECTOR,f_id=@FID WHERE f_id= @FID", con);
            cmd.Parameters.AddWithValue("@TID", textBox1.Text);
            cmd.Parameters.AddWithValue("@TNAME", textBox2.Text);
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
            //Datagrid show
            SqlCommand cmd1 = new SqlCommand(@"
               SELECT t.*
            FROM tenant t 
            JOIN flat f ON t.f_id = f.f_id
            JOIN own e ON f.b_id = e.b_id
            WHERE e.o_id = @OwnerId", con);
            cmd1.Parameters.AddWithValue("@OwnerId", UserId);
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

            SqlCommand cmd = new SqlCommand("DELETE FROM tenant WHERE t_id = @TID", con);
            cmd.Parameters.AddWithValue("@TID", textBox1.Text);

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
               SELECT t.*
            FROM tenant t
            JOIN flat f ON t.f_id = f.f_id
            JOIN own e ON f.b_id = e.b_id
            WHERE e.o_id = @OwnerId", con);
            cmd1.Parameters.AddWithValue("@OwnerId", UserId);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            //Fill refresh rows(insert kore or edit kore)
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ownerdashboard o1 = new ownerdashboard(UserId);
            o1.Show();
            this.Hide();
        }

        private void tanentmanagement_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();
            //Datagrid show
            SqlCommand cmd1 = new SqlCommand(@"
               SELECT t.*
            FROM tenant t
            JOIN flat f ON t.f_id = f.f_id
            JOIN own e ON f.b_id = e.b_id
            WHERE e.o_id = @OwnerId", con);
            cmd1.Parameters.AddWithValue("@OwnerId", UserId);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            //Fill refresh rows(insert kore or edit kore)
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
