using System;
using NUnit.Framework;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace ReadExcil
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
        public void ReadExceltext2()
        {
            update_file util = new update_file();
            DataTable result = update_file.readExcel();
            Assert.AreEqual("Fri 10:00-11:50", result.Rows[5][5].ToString());
        }
        
        [Test]
        public void ReadExceltext()
        {
            update_file util = new update_file();
            DataTable result = update_file.readExcel();
            Assert.AreEqual("Introduction to Language and Society", result.Rows[2][0].ToString());
        }

        [Test]
        public void WriteLinetext()
        {
            Console.WriteLine("WriteLinetext method");
        }
    }
}
