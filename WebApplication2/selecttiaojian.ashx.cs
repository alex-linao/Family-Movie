using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Newtonsoft.Json;

namespace WebApplication2
{
    /// <summary>
    /// selecttiaojian 的摘要说明
    /// </summary>
    public class selecttiaojian : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            string tiaojian = context.Request["a"].ToString();
            DataTable dt = MovieBLL.BLL.select_tiaojian(tiaojian);
            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
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