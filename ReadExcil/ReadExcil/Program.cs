using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Text;
using System.Data;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;


namespace ReadExcil
{
    static class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            DataTable dt = readExcel();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++) // 循环每一行,excil的第一行默认不读
                {
                    //for(int j = 0; j < dt.Columns.Count; j ++ )
                    Console.WriteLine(dt.Rows[i][0].ToString());    // 这一行是将内容打印出来。二维数组的第一个数字为行，第二个数字为列
                }
                //Console.WriteLine(dt.Rows[5][4].ToString());
            }
        }

        static public DataTable readExcel()
        {
            string filename = "timetable.xls";
            string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " + filename + ";Extended Properties=Excel 8.0";
            OleDbConnection conn = new OleDbConnection(strCon);
            conn.Open();
            //返回Excel的架构，包括各个sheet表的名称,类型，创建时间和修改时间等　
            DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
            //包含excel中表名的字符串数组
            string[] strTableNames = new string[dtSheetName.Rows.Count];
            for (int k = 0; k < dtSheetName.Rows.Count; k++)
            {
                strTableNames[k] = dtSheetName.Rows[k]["TABLE_NAME"].ToString();
            }
            OleDbDataAdapter myCommand = null;
            DataTable dt = new DataTable();
            //从指定的表明查询数据,可先把所有表明列出来供用户选择
            string strExcel = "select * from [" + strTableNames[0] + "]";
            myCommand = new OleDbDataAdapter(strExcel, strCon);
            myCommand.Fill(dt);
            
            return dt;
        }

        static public void writeExcel(string teacher_name, string class_name, string room_name, string course_capacity, string Date_str, string course_name)
        {
            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
                string sql = null;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='timetable.xls';Extended Properties=Excel 8.0;");
                MyConnection.Open();
                myCommand.Connection = MyConnection;

                sql = "Update [21 DEC 2012$] set Teachers = '" + teacher_name +
                    "', [Classes] = '" + class_name +
                    "', [Room] = '" + room_name +
                    "', [Capacity] = '" + course_capacity +
                    "', [Date] = '" + Date_str +
                    "' where [Name] = '" + course_name + "'";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
