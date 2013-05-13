using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using System.Data.OleDb;  

namespace ReadExcil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = update_file.readExcel();
            
            // label1.Text = dt.Rows[3][0].ToString(); // 读取第4行 第1列
            string[] sArray;
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                comboBox1.Items.Add(dt.Rows[k][0]);
                comboBox1.Text = dt.Rows[k][0].ToString();

                textBox1.Text = dt.Rows[k][1].ToString();
                textBox2.Text = dt.Rows[k][2].ToString();
                textBox3.Text = dt.Rows[k][3].ToString();
                textBox4.Text = dt.Rows[k][4].ToString();

                sArray = dt.Rows[k][5].ToString().Split(new char[2] { ' ', '-' });
                comboBox3.Text = sArray[0];
                comboBox4.Text = sArray[1];
                comboBox5.Text = sArray[2];
                // comboBox2.Items.Add(dt.Rows[k][5]);
                // comboBox2.Text = dt.Rows[k][5].ToString();

            }
            /*
            for (int k = 0; k < dt.Rows.Count; k++) {
                if (comboBox1.Items[k].ToString() == comboBox1.Text.ToString())
                    label2.Text = k.ToString();
            }
             */
             // comboBox2.Text = (comboBox1.SelectedIndex+1).ToString();

            // 以下句子直接操作数据库
            string sql_select = "select * from [21 DEC 2012$] where [Date] = 'Fri 10:00-11:50' and [Room] = 'E208B'";
            DataTable datesql = update_file.readExcelSql(sql_select);
            label3.Text = datesql.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)  // change information of excel
        {
            string date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
            update_file.writeExcel(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), date_str, comboBox1.SelectedIndex+1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            ComboBox.SelectedText
            ComboBox.SelectedValue
            ComboBox.SelectedItem
             */
            // label2.Text = comboBox1.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DataTable dt = update_file.readExcel();

            int k = comboBox1.SelectedIndex;
            label2.Text = dt.Rows[k][0].ToString();
            string[] sArray;
            textBox1.Text = dt.Rows[k][1].ToString();
            textBox2.Text = dt.Rows[k][2].ToString();
            textBox3.Text = dt.Rows[k][3].ToString();
            textBox4.Text = dt.Rows[k][4].ToString();

            sArray = dt.Rows[k][5].ToString().Split(new char[2] { ' ', '-' });
            comboBox3.Text = sArray[0];
            comboBox4.Text = sArray[1];
            comboBox5.Text = sArray[2];
        }
    }
}
