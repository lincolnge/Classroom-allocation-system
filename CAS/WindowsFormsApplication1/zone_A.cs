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
    public partial class zone_A : Form
    {
        private string zone_name_init;
        private string[] classroom_name_init;
        //private string label;
        private string AmountNumber;
        private string Password;
        public zone_A(string zone_name, string[] classroom_name)
        {
            InitializeComponent();
            zone_name_init = zone_name;
            classroom_name_init = classroom_name;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zone Zone = new Zone(AmountNumber, Password);
            this.Hide();
            Zone.ShowDialog();
        }

        private void zone_A_Load(object sender, EventArgs e)
        {
            label1.Text = zone_name_init;            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int _Height = 100;
            int _Width = 20;
            for (int i = 0; i < 50; i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(_Width, _Height);
                _Width += label.Width;
                if (i % 10 == 0)
                {
                    _Width = 20;
                    _Height += label.Height;
                }
                if (classroom_name_init[i]!="")
                {
                    label.Text = classroom_name_init[i];
                }                
                
                Controls.Add(label);
                label.Parent = panel1;
            } 
        }
    }
}
