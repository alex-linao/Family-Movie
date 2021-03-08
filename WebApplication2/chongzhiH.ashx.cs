using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    /// <summary>
    /// chongzhiH 的摘要说明
    /// </summary>
    public class chongzhiH : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";


            string b = ClassLibrary1.Class1.q;
            string a = context.Request["a"].ToString();
            bool isucc = MovieBLL.BLL.chongzhi(a, b);


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