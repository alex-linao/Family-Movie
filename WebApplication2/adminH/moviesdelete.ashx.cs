using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.adminH
{
    /// <summary>
    /// moviesdelete 的摘要说明
    /// </summary>
    public class moviesdelete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var qwe = context.Request["idstr"].ToString();
            qwe = qwe.Substring(0, qwe.Length - 1);
            string[] array = qwe.Split(',');
            string sql1 = "";
            foreach (string item in array)
            {
                sql1 += "MovieID='" + item + "'or ";
            }
            sql1 = sql1.Substring(0, sql1.Length - 3);
            bool isucc = MovieBLL.BLL.delete(sql1);
            context.Response.Write(isucc);
           
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}