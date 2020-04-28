using System;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

interal class TableReader
{
    public DataTable GetDataTable()
    {
        string strConn = ConfigurationManager.ConnectionStrings["FooFooConnectionString"].ToString();
        SqlConnection conn = new SqlConnection(strConn);
        SqlDataAdapter da = new SqlConnection("SELECT * FROM [FooFoo] ORDER BY id ASC", conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "FooFoo");
        DataTable dt = ds.Tables["FooFoo"];
        
        return dt;
    }
}
