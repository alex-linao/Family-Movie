using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    /// <summary>
    /// goupiao 的摘要说明
    /// </summary>
    public class goupiao : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string MovieID12 = context.Request["MovieID12"].ToString();
            string OrderPrice1 = context.Request["OrderPrice1"].ToString();
            string OrderGenerateTime = context.Request["OrderGenerateTime"].ToString();
            string UserID = context.Request["UserID"].ToString();
            string Balance = context.Request["Balance"].ToString();//用户余额
            MovieModel.OrderModel aa =new MovieModel.OrderModel ();
            aa.MovieID = int.Parse(MovieID12);
            aa.OrderPrice = OrderPrice1;//电影价格
            aa.OrderGenerateTime = OrderGenerateTime;
            aa.UserID = int.Parse(UserID);
            bool isucc1 = MovieBLL.BLL.kouqian(OrderPrice1, UserID);
            bool isucc = MovieBLL.BLL.tianjiadingdan(aa);

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