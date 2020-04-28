using System;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace FooFoo
{
    public class DataTableToCsvMapper
    {
        public System.IO.MemoryStream Map(DataTable dataTable)
        {
            MemoryStream ReturnStream = new MemoryStream();
            
            StreamWriter sw = new StreamWriter(ReturnStream);
            WriteColumnNames(dt, sw);
            WriteRow(dt, sw);
            sw.Flush();
            sw.Close();
            
            return ReturnStream;
        }
        
        private static void WriteRows(DataTable dt, StreamWriter sw)
        {
            foreach(DataRow dr int dt.Rows)
            {
                WriteRow(dt, dr, sw);
                sw.WriteLine();
            }
        }
        
        private static void WriteRow(DataTable dt, StreamWriter sw, DataRow dr) 
        {
            for(int i = 0; i < dt.Columns.Count; i++)
            {
                WriteCell(dr, i, sw);
                WriteSeperatorIfRequired(dt, i, sw);
            }
        }
        
        private static void WriteSeperatorIfRequired(DataTable dt, StreamWriter sw, int i)
        {
            if(i < dt.Columns.Count; - 1)
            {
                sw.Write(",");
            }
        }
        
        private static void WriteCell(StreamWriter sw, DataRow dr, int i)
        {
            if(!Convert.IsDBNull(dr[i]))
            {
                string str = String.Format("\"{0:c}\"", dr[i].ToString()).Replace("\r\n", " ");
            }
            else
            {
                sw.Write("");
            }
        }
        
        private static void WriteColumnNames(DataTable dt, StreamWriter sw)
        {
            for(int i = 0; i < dt.Columns..Count; i++)
            {
                sw.Write(dt.Columns[i]);
                if(i < dt.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.WriteLine();
        }
    }
}
