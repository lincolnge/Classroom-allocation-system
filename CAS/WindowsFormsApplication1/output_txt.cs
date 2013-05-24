﻿using System;
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
            /*
            // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
            // You can modify the path if necessary. 

            // Example #1: Write an array of strings to a file. 
            // Create a string array that consists of three lines. 
            string[] lines = { "First line", "Second line", "Third line" };
            // WriteAllLines creates a file, writes a collection of strings to the file, 
            // and then closes the file.
            System.IO.File.WriteAllLines("WriteLines.txt", lines);


            // Example #2: Write one string to a text file. 
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file, 
            // and then closes the file.
            System.IO.File.WriteAllText("WriteText.txt", text);

            // Example #3: Write only some strings in an array to a file. 
            // The using statement automatically closes the stream and calls  
            // IDisposable.Dispose on the stream object. 
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file. 
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            // Example #4: Append new text to an existing file. 
            // The using statement automatically closes the stream and calls  
            // IDisposable.Dispose on the stream object. 
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("WriteLines2.txt", true))
            {
                file.WriteLine("Fourth line");
            }
             */

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
