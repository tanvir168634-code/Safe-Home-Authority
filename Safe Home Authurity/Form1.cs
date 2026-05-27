namespace Safe_Home_Authurity
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // Create instance of Form2
            form2.Show();               // Show Form2
            this.Hide();                // Hide the current form (Form1)
        }
    }
}
