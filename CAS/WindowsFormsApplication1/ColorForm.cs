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
    public partial class ColorForm : Form
    {
        private string product_name_init;
        public ColorForm(string product_name)
        {
            InitializeComponent();
            product_name_init = product_name;
        }

        private void SaveColor(string color, string fore_color)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("color.xml");
            XmlNodeList idList = xmlDoc.SelectNodes("//Product_name");
            foreach (XmlNode node in idList)
            {
                if (node.ParentNode.ChildNodes[0].InnerText == product_name_init)
                {
                    //         textBox1.Text = node.ParentNode.ChildNodes[1].InnerText;//debug something
                    node.ParentNode.ChildNodes[1].InnerText = color.ToString();
                    node.ParentNode.ChildNodes[2].InnerText = fore_color.ToString();
                }
            }
            xmlDoc.Save("color.xml");
            this.Close();
        }

        private void White_Click(object sender, EventArgs e)
        {
            SaveColor("White", "Black");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Red_Click(object sender, EventArgs e)
        {
            SaveColor("Red", "White");
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            SaveColor("Orange", "Black");
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            SaveColor("Yellow", "Black");
        }

        private void Green_Click(object sender, EventArgs e)
        {
            SaveColor("Green", "White");
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            SaveColor("Blue", "White");
        }

        private void indigo_Click(object sender, EventArgs e)
        {
            SaveColor("indigo", "White");
        }

        private void purple_Click(object sender, EventArgs e)
        {
            SaveColor("purple", "White");
        }

        private void Black_Click(object sender, EventArgs e)
        {
            SaveColor("Black", "White");
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
