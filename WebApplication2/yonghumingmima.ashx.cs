using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Newtonsoft.Json;

namespace WebApplication2
{
    /// <summary>
    /// yonghumingmima 的摘要说明
    /// </summary>
    public class yonghumingmima : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            string num = context.Request["username"].ToString();
            string pwd = context.Request["password"].ToString();
            MovieModel.UserModel aa = new MovieModel.UserModel();
            aa.UserNumber = int.Parse(num);
            aa.UserPwd = pwd;
            DataTable dt = MovieBLL.BLL.yonghuingmima(aa);
            string json = JsonConvert.SerializeObject(dt);
            string q = dt.Rows.Count.ToString();
            if (q=="1")
            {
                ClassLibrary1.Class1.q = num;
            }
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