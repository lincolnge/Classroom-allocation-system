using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            textBox3.Text = label1.Text;
            
            string[] sArray;
            sArray = date_str_init.Split(new char[2] { ' ', '-' });
            comboBox3.Text = sArray[0];
            comboBox4.Text = sArray[1];
            comboBox5.Text = sArray[2];
            
            DataTable dt = update_file.readExcel();
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                comboBox1.Items.Add(dt.Rows[k][0]);
                try
                {
                    if (date_str_init == dt.Rows[k][5].ToString() && classroom_name_One_init == dt.Rows[k][3].ToString())
                    {
                        comboBox1.Text = dt.Rows[k][0].ToString();

                        textBox1.Text = dt.Rows[k][1].ToString();
                        textBox2.Text = dt.Rows[k][2].ToString();
                        textBox3.Text = dt.Rows[k][3].ToString();
                        textBox4.Text = dt.Rows[k][4].ToString();

                        break;
                    }
                    else
                    {

                    }
                }
                catch
                {
                }
             
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        // This is a comfirm button, if label3 has no course, it means adding course, if labels3 has course, it means change course information
        private void button1_Click(object sender, EventArgs e)  // add or change
        {
            string date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
            if (label3.Text != "There is no classroom!" && label3.Text != "" && label3.Text != "label3")
            {
                if (MessageBox.Show("Change Classroom Information...?", "Comfirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // code here
                    string sql_select = "Update [21 DEC 2012$] set Teachers = '" + textBox1.Text.ToString() +
                        "', [Classes] = '" + textBox2.Text.ToString() +
                        "', [Room] = '" + textBox3.Text.ToString() +
                        "', [Capacity] = '" + textBox4.Text.ToString() +
                        "', [Name] = '" + comboBox1.Text.ToString() +
                        "' where [Date] = '" + date_str + "' and [Room] = '" + label1.Text + "'";
                    
                    DataTable dt = update_file.readExcelSql(sql_select);

                    // memo part
                    string content = "Date" + " : " + date_str + " \n" +
                        "CourseName" + " : " + comboBox1.Text + " \n" +
                        "TeacherName" + " : " + textBox1.Text + " \n" +
                        "ClassName" + " : " + textBox2.Text + " \n" +
                        "RoomName" + " : " + textBox3.Text + " \n" +
                        "Capacity" + " : " + textBox4.Text; 
                    output_txt.output_textfile(content, "change");
                }
            }
            else
            {
                if (MessageBox.Show("add Classroom Information...?", "Comfirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataTable dt2 = update_file.readExcel();
                    int id = 0;
                    for (int k = 0; k < 1000; k++) // 课程上限为1000
                    {
                        if (dt2.Rows[k][0].ToString() == "")
                        {
                            id = k + 1;
                            break;
                        }
                    }
                    if (id == 0 && false) // no finish part
                    {
                        MessageBox.Show("you can't add more course!!!");
                    }
                    else
                    {
                        string sql_select = "Update [21 DEC 2012$] set Teachers = '" + textBox1.Text.ToString() +
                                "', [Classes] = '" + textBox2.Text.ToString() +
                                "', [Room] = '" + textBox3.Text.ToString() +
                                "', [Capacity] = '" + textBox4.Text.ToString() +
                                "', [Date] = '" + date_str +
                                "', [Name] = '" + comboBox1.Text.ToString() +
                                "' where [id] = " + id;

                        DataTable dt = update_file.readExcelSql(sql_select);

                        // memo part
                        string content = "Date" + " : " + date_str + " \n" +
                        "CourseName" + " : " + comboBox1.Text + " \n" +
                        "TeacherName" + " : " + textBox1.Text + " \n" +
                        "ClassName" + " : " + textBox2.Text + " \n" +
                        "RoomName" + " : " + textBox3.Text + " \n" +
                        "Capacity" + " : " + textBox4.Text;
                        output_txt.output_textfile(content, "add");
                    }
                }
            }
            showclassroom();
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            string date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
            try
            {
                string sql_select = "select * from [21 DEC 2012$] where [Date] = '" + date_str + "' and [Room] = '" + label1.Text + "'";
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
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e) // remove 
        {
            string date_str = comboBox3.Text + " " + comboBox4.Text + "-" + comboBox5.Text;
            if (MessageBox.Show("Deleting...?", "Comfirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // code here
                // 貌似可行
                string sql_select = "Update [21 DEC 2012$] set Teachers = '" + "" +
                        "', [Classes] = '" + "" +
                        "', [Room] = '" + "" +
                        "', [Capacity] = '" + 0 + // capacity 要有值就行！
                        "', [Date] = '" + "" +
                        "', [Name] = '" + "" +
                        "' where [Date] = '" + date_str + "' and [Room] = '" + label1.Text + "'";

                DataTable dt = update_file.readExcelSql(sql_select);
                
                // memo part
                output_txt.output_textfile(label3.Text, "delete");
            }
            showclassroom();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
