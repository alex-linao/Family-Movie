using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Newtonsoft.Json;

namespace WebApplication2
{
    /// <summary>
    /// selectMovieID 的摘要说明
    /// </summary>
    public class selectMovieID : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            string MovieID = context.Request["a"].ToString();
            DataTable dt = MovieBLL.BLL.selectall(MovieID);
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