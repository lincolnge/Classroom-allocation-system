using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class output_txt
    {
        static public void output_textfile(string content, string control)
        {
            FileStream fs = new FileStream("memo.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(System.DateTime.Now);  // show now DateTime
            sw.WriteLine(control +" classroom information");
            //sw.WriteLine(label3.Text, true);
            sw.WriteLine(content, true);
            sw.WriteLine("===========");
            sw.Close();
            fs.Close();
            MessageBox.Show("Done!");
        }
    }
}
