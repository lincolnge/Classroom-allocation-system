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
    public partial class Classroom : Form
    {
        private string zone_name_init;
        private string[] classroom_name_init;
        private string classroom_name_One_init;
        private string date_str_init;

        public Classroom(string zone_name, string[] classroom_name, string classroom_name_One, string date_str)
        {
            InitializeComponent();
            zone_name_init = zone_name;
            classroom_name_init = classroom_name;
            classroom_name_One_init = classroom_name_One;
            date_str_init = date_str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zone_A Zone = new zone_A(zone_name_init, classroom_name_init);
            this.Hide();
            Zone.ShowDialog();
        }

        private void Classroom_Load(object sender, EventArgs e)
        {
            label1.Text = classroom_name_One_init;

            string[] sArray;
            sArray = date_str_init.Split(new char[2] { ' ', '-' });
            comboBox3.Text = sArray[0];
            comboBox4.Text = sArray[1];
            comboBox5.Text = sArray[2]; 

            DataTable dt = update_file.readExcel();
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                comboBox1.Items.Add(dt.Rows[k][0]);
                if (date_str_init == dt.Rows[k][5].ToString() && classroom_name_One_init == dt.Rows[k][3].ToString())
                {
                    comboBox1.Text = dt.Rows[k][0].ToString();

                    textBox1.Text = dt.Rows[k][1].ToString();
                    textBox2.Text = dt.Rows[k][2].ToString();
                    textBox3.Text = dt.Rows[k][3].ToString();
                    textBox4.Text = dt.Rows[k][4].ToString();

                    // label2.Text = date_str_init;
                    break;
                }
                else
                {
                    // label2.Text = "There is no course on " + date_str_init;
                    label2.Text = "There is no course";
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
            update_file.writeExcel(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), date_str, comboBox1.SelectedIndex + 1);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            string date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
            try
            {
                string sql_select = "select * from [21 DEC 2012$] where [Date] = '" + date_str + "' and [Room] = '" + label1.Text + "'";
                // string sql_select = "select * from [21 DEC 2012$] where [Date] = 'Tue 17:00-17:50' and [Room] = '" + label1.Text + "'";
                DataTable dt = update_file.readExcelSql(sql_select);

                label3.Text = dt.Rows[0][0].ToString() + "\n\n" +
                    dt.Rows[0][1].ToString() + "\n\n" +
                    dt.Rows[0][2].ToString() + "\n\n" +
                    dt.Rows[0][3].ToString() + "\n\n" +
                    dt.Rows[0][4].ToString();
                comboBox1.Text = dt.Rows[0][0].ToString();
            }
            catch
            {
                label3.Text = "There is no classroom!";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  // transfer
        {
            /*
            string date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
            try
            {
                string sql_select = "select * from [21 DEC 2012$] where [Date] = '" + date_str + "' and [Room] = '" + label1.Text + "'";
                DataTable dt = update_file.readExcelSql(sql_select);

                label2.Text = dt.Rows[0][0].ToString();
                comboBox1.Text = dt.Rows[0][0].ToString();
                textBox1.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0][2].ToString();
                textBox3.Text = dt.Rows[0][3].ToString();
                textBox4.Text = dt.Rows[0][4].ToString();
            }
            catch
            {

            }
             */
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
