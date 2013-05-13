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

        private string date_str;
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
            label1.Text = zone_name_init + "-Zone";


            string[] sArray;
            sArray = "Mon 8:00-8:50".Split(new char[2] { ' ', '-' });
            comboBox3.Text = sArray[0];
            comboBox4.Text = sArray[1];
            comboBox5.Text = sArray[2];           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*
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
                if (classroom_name_init[i]!=null)
                {
                    label.Text = zone_name_init + classroom_name_init[i];
                }                
                Controls.Add(label);
                label.Parent = panel1;        
            }
             */

            button1.Text = "B201";
            button2.Text = "B202";
            button3.Text = "B203";
            button4.Text = "B301";
            button6.Text = "B302";
            button7.Text = "B303";

            date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text; 
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classroom classroom = new Classroom(zone_name_init, classroom_name_init, button1.Text, date_str);
            this.Hide();
            classroom.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classroom classroom = new Classroom(zone_name_init, classroom_name_init, button2.Text, date_str);
            this.Hide();
            classroom.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Classroom classroom = new Classroom(zone_name_init, classroom_name_init, button3.Text, date_str);
            this.Hide();
            classroom.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Classroom classroom = new Classroom(zone_name_init, classroom_name_init, button4.Text, date_str);
            this.Hide();
            classroom.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Classroom classroom = new Classroom(zone_name_init, classroom_name_init, button6.Text, date_str);
            this.Hide();
            classroom.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Classroom classroom = new Classroom(zone_name_init, classroom_name_init, button7.Text, date_str);
            this.Hide();
            classroom.ShowDialog();
        }

    }
}
