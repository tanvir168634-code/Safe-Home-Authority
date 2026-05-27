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




    public partial class policedashboard : Form
    {

        public policedashboard()
        {
            InitializeComponent();
        }

        private void policedashboard_Load(object sender, EventArgs e)
        {

            LoadData(@"
SELECT 
    o.o_id [ Owner_ID] ,
    o.o_name  [Owner_name],
    o.o_mobile  [ Mobile_number],
    
  

    b.b_id [ Building_ID],
    b.b_name [Building_name],
    b.city  [Building_city],
    b.sector  [Building_sector],

    f.f_id [Flat_ID],
    f.f_number [Flat_name],

    t.t_id [Tanent_ID],
    t.t_name [Tanent_name],
    t.city [Tanent_City],
    t.sector [Tanent_Sector],

    w.w_id [Worker_ID],
    w.w_name [Worker_name],
     w.w_number [Worker_Mobile number]

FROM owner o
JOIN own b ON o.o_id = b.o_id
LEFT JOIN flat f ON b.b_id = f.b_id
LEFT JOIN tenant t ON f.f_id = t.f_id
LEFT JOIN workers w ON f.f_id = w.f_id", dataGridView1);


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoadData(string query, DataGridView dgv)

        {
            string connectionString = "Data Source=DELL-3410\\SQLEXPRESS;Initial Catalog=authority;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            // Step 4: Define the SQL query
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature will avaiable soon");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature will avaiable soon");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            policeshowall p1 = new policeshowall();
            p1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout successful!", "Success", MessageBoxButtons.OK);
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
