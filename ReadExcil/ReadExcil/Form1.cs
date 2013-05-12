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
            DataTable dt = Program.readExcel();
            label1.Text = dt.Rows[3][0].ToString(); // 读取第4行 第1列
            
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                comboBox1.Items.Add(dt.Rows[k][0]);
                comboBox1.Text = dt.Rows[k][0].ToString();

                textBox1.Text = dt.Rows[k][1].ToString();
                textBox2.Text = dt.Rows[k][2].ToString();
                textBox3.Text = dt.Rows[k][3].ToString();
                textBox4.Text = dt.Rows[k][4].ToString();

                comboBox2.Items.Add(dt.Rows[k][5]);
                comboBox2.Text = dt.Rows[k][5].ToString();

            }
            /*
            for (int k = 0; k < dt.Rows.Count; k++) {
                if (comboBox1.Items[k].ToString() == comboBox1.Text.ToString())
                    label2.Text = k.ToString();
            }
             */
             comboBox2.Text = (comboBox1.SelectedIndex+1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)  // change information of excel
        {
            Program.writeExcel(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), comboBox2.SelectedItem.ToString(), comboBox1.SelectedIndex+1);
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
    }
}
