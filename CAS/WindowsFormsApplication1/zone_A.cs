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

        public string date_str;
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

            showclassroom();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {            
            panel1.SendToBack();//置于底层
        }

        void Buttons_Click(object sender, EventArgs e)
        {
            date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
            this.Text = (sender as Button).Text;
            Classroom classroom = new Classroom(zone_name_init, classroom_name_init, this.Text, date_str);
            this.Hide();
            classroom.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            showclassroom();
        }

        private void showclassroom()
        {
            try
            {
                Button[] buttons = new Button[50];
                // for (int i = 0; i < 5; i++) // 只产生5个button
                for (int i = 0; i < classroom_name_init.Length; i++)
                {
                    int t_y = i / 10;
                    int t_x = i % 10;
                    if (classroom_name_init[i] != null)
                    {
                        buttons[i] = new Button();
                        buttons[i].Name = "button" + i;
                        // buttons[i].Text = buttons[i].Name;
                        buttons[i].Text = zone_name_init + classroom_name_init[i];
                        buttons[i].Size = new Size(60, 25);
                        buttons[i].Location = new Point(110 + 70 * t_x, 210 + 50 * t_y);

                        //panel1.Controls.Add(buttons[i]);
                        buttons[i].BringToFront();//置于顶层
                        buttons[i].Click += new EventHandler(Buttons_Click);                        
                    }
                    else
                    {

                    }
                }
                this.Controls.AddRange(buttons);
            }
            catch
            {
                //label3.Text = "There is no classroom!";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            showclassroom();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            showclassroom();
        }
        
    }
}
