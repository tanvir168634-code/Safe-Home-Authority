using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safe_Home_Authurity
{
    public partial class ownershowall : Form
    {
        string UserId;
        public ownershowall(string userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void ownershowall_Load(object sender, EventArgs e)
        {




            string buildingid = textBox1.Text;


            string connectionString = "Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            string query = @"SELECT 
                 o.o_id AS [OWNER ID],
                 o.b_id AS [Building ID],
                 o.b_name AS [Building Name],
                 o.city AS [Owner City],
                 o.sector AS [Owner Sector],

                 f.f_id AS [Flat ID],
                 f.f_number AS [Flat Number],

                 t.t_id AS [Tenant ID],
                 t.t_name AS [Tenant Name],
                 t.city AS [Tenant City],
                 t.sector AS [Tenant Sector],

                 w.w_id AS [Worker ID],
                 w.w_name AS [Worker Name],
                 w.city AS [Worker City],
                 w.sector AS [Worker Sector],
                 w.w_number AS [Worker Mobile No]

                FROM own o
                LEFT JOIN flat f ON o.b_id = f.b_id
                LEFT JOIN tenant t ON f.f_id = t.f_id
                LEFT JOIN workers w ON f.f_id = w.f_id
               

                WHERE o.o_id = @UserId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", UserId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            string searchText = "%" + search + "%"; // txtSearch is the TextBox where user types


            string connectionString = "Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            string query = @"SELECT 
                 o.o_id AS [OWNER ID],
                 o.b_id AS [Building ID],
                 o.b_name AS [Building Name],
                 o.city AS [Owner City],
                 o.sector AS [Owner Sector],

                 f.f_id AS [Flat ID],
                 f.f_number AS [Flat Number],

                 t.t_id AS [Tenant ID],
                 t.t_name AS [Tenant Name],
                 t.city AS [Tenant City],
                 t.sector AS [Tenant Sector],

                 w.w_id AS [Worker ID],
                 w.w_name AS [Worker Name],
                 w.city AS [Worker City],
                 w.sector AS [Worker Sector],
                      w.w_number AS [Worker Mobile No]
                FROM own o
                INNER JOIN flat f ON o.b_id = f.b_id
                LEFT JOIN tenant t ON f.f_id = t.f_id
                LEFT JOIN workers w ON f.f_id = w.f_id

                WHERE 

                    o.o_id = @UserId AND
                    (
                    o.b_id LIKE @Search OR
                    o.b_name LIKE @Search OR
                    o.city LIKE @Search OR
                    o.sector LIKE @Search OR
                    f.f_id LIKE @Search OR
                    f.f_number LIKE @Search OR
                    t.t_id LIKE @Search OR
                    t.t_name LIKE @Search OR
                    t.city LIKE @Search OR
                    t.sector LIKE @Search OR
                    w.w_id LIKE @Search OR
                    w.w_name LIKE @Search OR
                    w.city LIKE @Search OR
                    w.sector LIKE @Search )";
            

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Search", "%" + search + "%"); // txtSearch is your search TextBox
                cmd.Parameters.AddWithValue("@UserId", UserId); // txtSearch is your search TextBox
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
