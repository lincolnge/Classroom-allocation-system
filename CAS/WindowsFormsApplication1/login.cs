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
    public partial class login : Form
    {
    //    dllEncrypt dE = new dllEncrypt();
        private int k = 0;// k is a value number to control if account number is error
        
        public login()
        {
            InitializeComponent();
            /*
            for (int x = 0; x < 5;x++ )
            {
                Graphics dc = CreateGraphics();
                Show();
                Pen bluePen = new Pen(Color.Blue, 3);
                dc.DrawRectangle(bluePen, x*80, 0, 50, 50);
            }
            */
            /*
            int _Height = 0;
            
            for (int i = 0; i < 10; i++)
            {
                Label sy = new Label();
                sy.AutoSize = true;
                sy.Location = new Point(0, _Height);
                _Height += sy.Height;
                sy.Text = i.ToString();
                Controls.Add(sy);
            } 
             */
        }


        private void button2_Click(object sender, EventArgs e)//reset button
        {
            textBox.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)//enter button
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("product.xml");
            XmlNodeList idList = xmlDoc.SelectNodes("//Product_id");
            foreach (XmlNode node in idList)
            {
                int a = 0;//a is temp value
                string p;
                p = node.ParentNode.ChildNodes[1].InnerText;
                a = int.Parse(p);//字符串转数字
                a = ( a + 1024 ) / 256;
                p = a.ToString();

                if (node.ParentNode.ChildNodes[0].InnerText == textBox.Text && textBox2.Text == p)
                {
                    //textBox.Text is amount number; textBox2.Text is password
                    Zone frm2 = new Zone(textBox.Text,textBox2.Text);

                    StartPosition = FormStartPosition.CenterParent;
                    this.Hide();//hide the first winform
                    frm2.ShowDialog();
                    this.Show();//open the first winform
                    k = 1;
                }
                if (node.ParentNode.ChildNodes[0].InnerText == textBox.Text && textBox2.Text != node.ParentNode.ChildNodes[1].InnerText)
                {
        //            MessageBox.Show("AMOUNT NUMBER OR PASSWORD IS ERROR! PLEASE TRY AGAIN");
                }
                
            }
            if (k == 0)
            {
              //  MessageBox.Show("AMOUNT NUMBER OR PASSWORD IS ERROR! PLEASE TRY AGAIN");
                string str = "AMOUNT NUMBER OR PASSWORD IS ERROR! \n PLEASE TRY AGAIN";
                login_error frm9 = new login_error(str);
                this.Hide();
                frm9.ShowDialog();
                this.Show();
            }
            k = 0;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountNumber(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                default:
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void Password(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                default:
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)    // exit_button
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
