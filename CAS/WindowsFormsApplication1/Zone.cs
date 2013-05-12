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
    public partial class Zone : Form
    {
        private string AmountNumber;
        private string Password;

        public Zone(string textBox, string textBox2)
        {
            InitializeComponent();
            AmountNumber = textBox;
            Password = textBox2;
        }

        public Zone()
        {
            InitializeComponent();
        }

        
        private void button5_Click(object sender, EventArgs e)  //take card button
        {
            StartPosition = FormStartPosition.CenterParent;
            this.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)  // zone_A
        {
            string zone_name = "A";
            string[] classroom_name;
            classroom_name = new string[50];

            classroom_name[0] = "There is not classroom!!!";

            zone_A zoneA = new zone_A(zone_name, classroom_name);
            this.Hide();
            zoneA.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)  // zone_B
        {
            string zone_name = "B";
            string[] classroom_name;
            classroom_name = new string[50];

            classroom_name[21] = "201";
            classroom_name[22] = "202";
            classroom_name[23] = "203";
            classroom_name[31] = "301";
            classroom_name[32] = "302";
            classroom_name[33] = "303";

            zone_A zoneA = new zone_A(zone_name, classroom_name);
            this.Hide();
            zoneA.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)  // zone_C
        {
            string zone_name = "C";
            string[] classroom_name;
            classroom_name = new string[50];

            classroom_name[1] = "121";
            classroom_name[2] = "122";
            classroom_name[3] = "123";
            classroom_name[4] = "124";
            classroom_name[5] = "125";
            classroom_name[6] = "126";
            classroom_name[7] = "127";
            classroom_name[8] = "128";
            classroom_name[23] = "203";
            classroom_name[24] = "204";
            classroom_name[25] = "205";
            classroom_name[26] = "206";
            classroom_name[27] = "207";
            classroom_name[28] = "208";
            classroom_name[29] = "209";
            classroom_name[20] = "210";
            classroom_name[31] = "301";
            classroom_name[32] = "302";
            classroom_name[33] = "303";
            classroom_name[34] = "304";
            classroom_name[35] = "305";
            classroom_name[36] = "306";
            classroom_name[37] = "307";
            classroom_name[42] = "402";
            classroom_name[43] = "403";
            classroom_name[44] = "404";
            classroom_name[45] = "405";
            classroom_name[46] = "406";
            classroom_name[47] = "407";

            zone_A zoneA = new zone_A(zone_name, classroom_name);
            this.Hide();
            zoneA.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)  // zone_D
        {
            string zone_name = "D";
            string[] classroom_name;
            classroom_name = new string[50];

            classroom_name[31] = "301";
            classroom_name[32] = "302";
            classroom_name[33] = "303";
            classroom_name[34] = "304";
            classroom_name[35] = "305";
            classroom_name[36] = "306";
            classroom_name[44] = "404";
            classroom_name[45] = "405";
            classroom_name[46] = "406";
            classroom_name[47] = "407";
            classroom_name[48] = "408";

            zone_A zoneA = new zone_A(zone_name, classroom_name);
            this.Hide();
            zoneA.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e) // zone_E
        {
            string zone_name = "E";
            string[] classroom_name;
            classroom_name = new string[50];

            classroom_name[1] = "101";
            classroom_name[2] = "102";
            classroom_name[3] = "103";
            classroom_name[4] = "104";
            classroom_name[5] = "105";
            classroom_name[6] = "106";
            classroom_name[21] = "201";
            classroom_name[22] = "202";
            classroom_name[24] = "204";
            classroom_name[31] = "301";
            classroom_name[41] = "401";

            zone_A zoneA = new zone_A(zone_name, classroom_name);
            this.Hide();
            zoneA.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e) // zone_F
        {
            string zone_name = "F";
            string[] classroom_name;
            classroom_name = new string[50];

            classroom_name[31] = "301";
            classroom_name[32] = "302";
            classroom_name[33] = "303";

            zone_A zoneA = new zone_A(zone_name, classroom_name);
            this.Hide();
            zoneA.ShowDialog();
        }
    }
}
