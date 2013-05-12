using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class login_error : Form
    {
        // private string AmountNumber;
        // private string Password;
        private string str;

        public login_error()
        {
            InitializeComponent();
        }

        public login_error(string strFrom)
        {
            InitializeComponent();
            str = strFrom;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
