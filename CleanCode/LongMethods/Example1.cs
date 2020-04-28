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
        private readonly DataTableToCsvMapper _dataTableToCsvMapper = new DataTableToCsvMapper();
        private readonly TableReader _tableReader = new TableReader();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ClearResponse();
            SetCacheability();
            WriteContentToResponse(byteArray);
        } 
        
        pirvate byte[] GetCsv()
        {
            System.IO.MemoryStream ms = _dataTableToCsvMapper.Map(_tableReader.GetDataTable());
            
            byte[] byteArray = ms.ToArray();
            ms.Flush();
            ms.Close();
        }
            
        private void WriteContentToResponse(byte[] byteArray)
        {
            Response.Charset = System.Text.UTF8Encoding.UTF8.WebName;
            Response.ContentEncoding = System.Text.UTF8Encoding.UTF8;
            
            Response.ContentType = "text/comma-separated-values";
            Response.AppendHeder("Content-Disposition", "attachment; filename=FooFoo.csv");
            Response.AppendHeder("Content-Length", byteArray.Length.ToString());
            Response.BinaryWrite(byteArray);
        }
            
        private void ClearResponse()
        {
            Response.Cache.SetCacheability(HttpCacheability.Private);
            Response.CacheControl = "private";
            Response.AppendHeder("Pragma", "cache");
            Response.AppendHeder("Expires", "60");
        }
            
        private void SetCacheability()
        {
            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Cookies.Clear();
        }
    }
}
