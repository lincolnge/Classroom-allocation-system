﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Text;
using System.Data;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public class update_file
    {
        static public DataTable readExcel() // 读取excel
        {
            try
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
            catch
            {
                MessageBox.Show("You have not timetable.xls file, please create it.");
                return null;
            }
        }

        // 写入excel
        static public void writeExcel(string teacher_name, string class_name, string room_name, string course_capacity, string Date_str, int course_id)
        {
            // int int_course_id = int.Parse(course_id);
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
                    // "' where [Name] = '" + course_name + "'";
                    "' where [id] = " + course_id;
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // read content from excel with sql 
        static public DataTable readExcelSql(string sql_select)
        {
            try
            {
                string filename = "timetable.xls";
                string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " + filename + ";Extended Properties=Excel 8.0";
                OleDbConnection conn = new OleDbConnection(strCon);
                conn.Open();
                //返回Excel的架构，包括各个sheet表的名称,类型，创建时间和修改时间等　
                DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
                //包含excel中表名的字符串数组
                OleDbDataAdapter myCommand = null;
                DataTable dt = new DataTable();
                //从指定的表明查询数据,可先把所有表明列出来供用户选择
                string strExcel = sql_select;
                // string strExcel = "select * from [21 DEC 2012$] where [Date] = 'Fri 10:00-11:50' and [Room] = 'null'";   // select 亲测成功
                // string strExcel = "select * from [21 DEC 2012$] where [Date] = [" + Date_str + "] and [Room] = " + Classroom_str + "]";
                // strExcel = "Insert into [21 DEC 2012$] (Name, Teachers, Classes, Room, Capacity, Date, id) values('SDF', 'SDF', 'SDF', 'SDF', 'SDF', 'SDF', '700')";
                // strExcel = "Update [21 DEC 2012$] set Teachers = 3 where id = 1"; // update 亲测成功
                // strExcel = "Delete [21 DEC 2012$] where id = 1";
                // strExcel = "Insert into [Sheet1$] (id,name) values('5','e')";
                myCommand = new OleDbDataAdapter(strExcel, strCon);
                myCommand.Fill(dt);
                // conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

    }
}
