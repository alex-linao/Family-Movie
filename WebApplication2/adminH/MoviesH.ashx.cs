using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Newtonsoft.Json;

namespace WebApplication2.adminH
{
    /// <summary>
    /// MoviesH 的摘要说明
    /// </summary>
    public class MoviesH : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application / json";

            int flag = int.Parse(context.Request["flag"].ToString());

            if (flag == 0)//所有电影
            {
                select_moviesall(context);
            }
            if (flag == 1)
            {
                delete(context);
            }
            if (flag == 2)
            {
                select_movies(context);
            }
            if (flag == 3)
            {
                select_User(context);
            }
            if (flag == 4)
            {
                select_user(context);
            }
            if (flag == 5)//个人资料
            {
                select_User_gerenziliao(context);
            }
            if (flag == 6)//充值
            {
                chongzhi(context);
            }
            if (flag == 7)//查订单
            {
                chadingdan(context);
            }
            if (flag == 8) //判断该用户是否购买了此电影
            {
                select_or_dingdan(context);
            }
            if (flag == 9)//查询所有电影_科幻 8个
            {
                select8(context);
            }
            if (flag == 10)//查询所有电影_动作 8个
            {
                select8_dongzuo(context);
            }
            if (flag == 11)//查询7个推荐
            {
                select_7_tuijianindex(context);
            }
            if (flag == 12)//查询所有电影_综艺 8个
            {
                select8_zongyi(context);
            } 
            if (flag == 13)//查询所有电影_动漫 8个
            {
                select8_dongman(context);
            }
            if (flag == 14)//查询所有电影_动漫 8个
            {
                tuipiao(context);
            }
            if (flag == 15)//查询订单表
            {
                chaxundingdan_H(context);
            }
            //context.Response.Write("Hello World");
        }
        //查询订单表——后台
        public void chaxundingdan_H(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            DataTable dt = MovieBLL.BLL.chaxundingdan_H();
            string json = JsonConvert.SerializeObject(dt);

            context.Response.Write(json);
        }
        //退订单退款
        public void tuipiao(HttpContext context)
        {
            string OrderID = context.Request["OrderID"].ToString();
            string MoviePrice = context.Request["MoviePrice"].ToString();
            //string json = JsonConvert.SerializeObject(dt);
            string b = ClassLibrary1.Class1.q;

            bool isucc = MovieBLL.BLL.delete_dingdan(OrderID);
            bool isucc1 = MovieBLL.BLL.jiaqian(MoviePrice, b);
            DataTable dt = MovieBLL.BLL.selectall_user_dingdanbiao(b);

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //查询所有电影_动漫 8个
        public void select8_dongman(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            DataTable dt = MovieBLL.BLL.select8_dongman();
            string json = JsonConvert.SerializeObject(dt);

            context.Response.Write(json);
        }
        //查询所有电影_综艺 8个
        public void select8_zongyi(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            DataTable dt = MovieBLL.BLL.select8_zongyi();
            string json = JsonConvert.SerializeObject(dt);

            context.Response.Write(json);
        }
        //查询首页7个推荐
        public void select_7_tuijianindex(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            DataTable dt = MovieBLL.BLL.select();
            string json = JsonConvert.SerializeObject(dt);

            context.Response.Write(json);
        }
        //查询所有电影_动作 8个
        public void select8_dongzuo(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            DataTable dt = MovieBLL.BLL.select8_dongzuo();
            string json = JsonConvert.SerializeObject(dt);

            context.Response.Write(json);
        }
        //判断该用户是否购买了此电影
        public void select_or_dingdan(HttpContext context)
        {

            string b = ClassLibrary1.Class1.q;
            string a = context.Request["a"].ToString();
            DataTable dt = MovieBLL.BLL.select_or_dingdan(a, b);
            string json = JsonConvert.SerializeObject(dt);

            context.Response.Write(json);
        }
        //查询用户订单表
        public void chadingdan(HttpContext context)
        {

            string b = ClassLibrary1.Class1.q;

            DataTable dt = MovieBLL.BLL.selectall_user_dingdanbiao(b);

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //充值按钮
        public void chongzhi(HttpContext context)
        {

            string b = ClassLibrary1.Class1.q;
            string a = context.Request["a"].ToString();
            bool isucc = MovieBLL.BLL.chongzhi(a, b);


            context.Response.Write(isucc);
        }
        //查询传入的ID用户信息
        public void select_User_gerenziliao(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            //string tiaojian = context.Request["q"].ToString();
            //DataTable dt = MovieBLL.BLL.select_tiaojian(tiaojian);
            string q = ClassLibrary1.Class1.q;

            if (q != null)
            {
                DataTable dt = MovieBLL.BLL.selectall_user_gerenziliao(q);
                string json = JsonConvert.SerializeObject(dt);
                context.Response.Write(json);
            }
            else
            {
                context.Response.Write("123");
            }



        }
        //查询所有电影_科幻 8个
        public void select8(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            DataTable dt = MovieBLL.BLL.select8();
            string json = JsonConvert.SerializeObject(dt);

            context.Response.Write(json);
        }
        //查询所有用户信息
        public void select_User(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            //string tiaojian = context.Request["q"].ToString();
            //DataTable dt = MovieBLL.BLL.select_tiaojian(tiaojian);

            DataTable dt = MovieBLL.BLL.selectall_user();
            string json = JsonConvert.SerializeObject(dt);

            context.Response.Write(json);
        }
        //模糊查询电影用户
        public void select_user(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            string tiaojian = context.Request["q"].ToString();
            DataTable dt = MovieBLL.BLL.select_user_chuanzhi(tiaojian);
            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //模糊查询电影
        public void select_movies(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            string tiaojian = context.Request["q"].ToString();
            DataTable dt = MovieBLL.BLL.select_tiaojian(tiaojian);
            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //查询所有电影
        public void select_moviesall(HttpContext context)
        {
            //DataTable dt = MovieBLL.BLL.select_year2017();

            //string json = JsonConvert.SerializeObject(dt);
            DataTable dt = MovieBLL.BLL.selectAll();
            string json = JsonConvert.SerializeObject(dt);

            context.Response.Write(json);
        }
        //修改方法
        public void delete(HttpContext context)
        {
            string MovieID = context.Request["MovieID"].ToString();
            DataTable dt = MovieBLL.BLL.selectall(MovieID);//根据id查询该数据
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