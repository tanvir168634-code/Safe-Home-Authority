using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safe_Home_Authurity
{
    public partial class Developer : Form
    {
        string UserId;
        public Developer(string userid)
        {
            this.UserId = userid;
            InitializeComponent();
        }

        private void ownerallinfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
