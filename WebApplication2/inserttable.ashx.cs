using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace WebApplication2
{
    /// <summary>
    /// inserttable 的摘要说明
    /// </summary>
    public class inserttable : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string username = context.Request["username"].ToString();
            string password = context.Request["password"].ToString();
            string sex = context.Request["sex"].ToString();
            string age = context.Request["age"].ToString();
            string phone = context.Request["phone"].ToString();
            string name = context.Request["name"].ToString();

            MovieModel.UserModel aa = new MovieModel.UserModel();
            aa.UserNumber = int.Parse(username);
            aa.UserPwd = password;
            aa.UserSex = sex;
            aa.UserAge = age;
            aa.UserTel = phone;
            aa.UserName = name;
            aa.Balance = "0";
            bool isucc = MovieBLL.BLL.zhuce(aa);


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