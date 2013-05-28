using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class zone_A : Form
    {
        private string zone_name_init;
        private string[] classroom_name_init;

        public string date_str_init;
        public string sql_select;
        private string color_Occupied = "Red";
        private string color_Available = "Gray";
        private string color_ForeColor_Occ = "Black";
        private string color_ForeColor_Ava = "Black";
        private Button[] buttons = new Button[50];

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

                        colorChoise();
                        for (int k = 0; k < dt2.Rows.Count; k++)
                        {
                            if (dt2.Rows[k][3].ToString() == buttons[i].Text && dt2.Rows[k][5].ToString() == date_str.ToString())
                            {
                                // buttons[i].BackColor = Color.Red;
                                buttons[i].ForeColor = Color.FromName(color_ForeColor_Occ);
                                buttons[i].BackColor = Color.FromName(color_Occupied);
                                break;
                            }
                            else
                            {
                                buttons[i].ForeColor = Color.FromName(color_ForeColor_Ava);
                                buttons[i].BackColor = Color.FromName(color_Available);
                                // buttons[i].BackColor = Color.Gray;
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

        private void changeColor()
        {
            string date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
            sql_select = "select * from [21 DEC 2012$]";
            DataTable dt2 = update_file.readExcelSql(sql_select);
            try
            {
                for (int i = 0; i < classroom_name_init.Length; i++)
                {
                    if (classroom_name_init[i] != null)
                    {
                        buttons[i].Text = "hehe";
                    }
                }
            }
            catch
            {
                MessageBox.Show("hehe");
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

        private void Occupied_Click(object sender, EventArgs e)
        {
            ColorForm colorform = new ColorForm("Occupied");
            colorform.ShowDialog();
            changeColor();

        }

        private void Available_Click(object sender, EventArgs e)
        {
            ColorForm colorform = new ColorForm("Available");
            colorform.ShowDialog();
        }

        private void colorChoise()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("color.xml");
            XmlNodeList idList = xmlDoc.SelectNodes("//Product_color");
            color_Occupied = idList[0].InnerText;
            color_Available = idList[1].InnerText;

            XmlNodeList idList2 = xmlDoc.SelectNodes("//Product_ForeColor");
            color_ForeColor_Occ = idList2[0].InnerText;
            color_ForeColor_Ava = idList2[1].InnerText;
        }
        
    }
}
