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

        public string date_str_init;
        public string sql_select;

        //private string label;
        private string AmountNumber;
        private string Password;
        public zone_A(string zone_name, string[] classroom_name, string date_str)
        {
            InitializeComponent();
            zone_name_init = zone_name;
            classroom_name_init = classroom_name;
            date_str_init = date_str;
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
            /*
            string[] sArray;
            sArray = "Mon 8:00-8:50".Split(new char[2] { ' ', '-' });
            comboBox3.Text = sArray[0];
            comboBox4.Text = sArray[1];
            comboBox5.Text = sArray[2];
            */
            string[] sArray;
            sArray = date_str_init.Split(new char[2] { ' ', '-' });
            comboBox3.Text = sArray[0];
            comboBox4.Text = sArray[1];
            comboBox5.Text = sArray[2];
            //showclassroom();
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
            showclassroom(); // 没效果？？
        }

        void Buttons_Click(object sender, EventArgs e)
        {
            string date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
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
            string date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
            if (comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "")
                //    date_str = "Mon 8:00-8:50";
                date_str = date_str_init;
            label2.Text = date_str;
            //MessageBox.Show(date_str);

            //if(date_str == "Tue 10:00-10:50")
            //    MessageBox.Show("hehe");
            //sql_select = "select * from [21 DEC 2012$] where [Date] = '" + date_str + "'";

            try
            {
                sql_select = "select * from [21 DEC 2012$]";
                DataTable dt2 = update_file.readExcelSql(sql_select);
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

                        for (int k = 0; k < dt2.Rows.Count; k++)
                        {
                            if (dt2.Rows[k][3].ToString() == buttons[i].Text && date_str.ToString() == dt2.Rows[k][5].ToString())
                            {
                                buttons[i].BackColor = Color.Red;
                                break;
                            }
                            else
                            {
                                buttons[i].BackColor = Color.Gray;
                            }
                        }
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
                MessageBox.Show("error, can you check timatable.xls file or other errors");
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
