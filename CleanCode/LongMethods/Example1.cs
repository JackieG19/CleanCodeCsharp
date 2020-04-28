using System;
using System.Collection.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace FooFoo
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = CreateMemoryFile();
            
            byte[] byteArray = ms.ToArray();
            ms.Flush();
            ms.Close();
            
            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Cookies.Clear();
            Response.Cache.SetCacheability(HttpCacheability.Private);
            Response.CacheControl = "private";
            Response.Charset = System.Text.UTF8Encoding.UTF8.WebName;
            Response.ContentEncoding = System.Text.UTF8Encoding.UTF8;
            Response.AppendHeder("Pragma", "cache");
            Response.AppendHeder("Expires", "60");
            Response.ContentType = "text/comma-separated-values";
            Response.AppendHeder("Content-Disposition", "attachment; filename=FooFoo.csv");
            Response.AppendHeder("Content-Length", byteArray.Length.ToString());
            Response.BinaryWrite(byteArray);
        }
        
        public System.IO.MemoryStream CreateMemoryFile()
        {
            MemoryStream ReturnStream = new MemoryStream();
            
            try
            {
                string strConn = ConfigurationManager.ConnectionStrings["FooFooConnectionString"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                SqlDataAdapter da = new SqlConnection("SELECT * FROM [FooFoo] ORDER BY id ASC", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "FooFoo");
                DataTable dt = ds.Tables["FooFoo"];
                
                // create a streamwriter to writer to the memory stream
                StreamWriter sw = new StreamWriter(ReturnStream);
                
                int iColCount = dt.Columns.Count;
                
                for(int i = 0; i < iColCount; i++)
                {
                    sw.Write(dt.Columns[i]);
                    
                    if(i < iColCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                
                sw.Write();
                int intRows = dt.Rows.Count
                
                // Now write all the rows
                foreach(DataRow dr int dt.Rows)
                {
                    for(int i = 0; i < iColCount; i++)
                    {
                        if(!Convert.IsDBNull(dr[i]))
                        {
                            string str = String.Format("\"{0:c}\"", dr[i].ToString()).Replace("\r\n", " ");
                        }
                        
                        else
                        {
                            sw.Write("");
                        }
                        
                        if(i < iColCount - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();
                }
                sw.Flush();
                sw.Close();
            }
            catch(Expection Ex)
            {
                throw Ex;
            }
            return ReturnStream;
        }
    }
}
