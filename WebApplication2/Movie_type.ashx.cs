using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Data;

namespace WebApplication2
{
    /// <summary>
    /// Movie_type 的摘要说明
    /// </summary>
    public class Movie_type : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Clear();
            context.Response.ContentType = "text/html";
            //context.Response.Write("Hello World");
            string action = context.Request["action"].ToString();

            if (action == "type_xiju")//喜剧
            {
                type_xiju(context);
            }
            else if (action == "type_dongzuo")//动作
            {
                type_dongzuo(context);
            }
            else if (action == "type_zhongguo")//中国  
            {
                type_zhonguo(context);
            }
            else if (action == "type_xianggang")//香港  
            {
                type_xianggang(context);
            }
            else if (action == "type_taiwan")//台湾  
            {
                type_taiwan(context);
            }
            else if (action == "type_hanguo")//韩国  
            {
                type_hanguo(context);
            }
            else if (action == "type_meiguo")//美国 
            {
                type_meiguo(context);
            }
            else if (action == "type_riben")//日本 
            {
                type_riben(context);
            }
            else if (action == "type_2017")//2017
            {
                type_2017(context);
            }
            else if (action == "type_2016")//2016
            {
                type_2016(context);
            }
            else if (action == "type_2015")//2015
            {
                type_2015(context);
            }
            else if (action == "type_aiqing")//爱情
            {
                type_aiqing(context);
            }
            else if (action == "type_xuanyi")//悬疑
            {
                type_xuanyi(context);
            }
            else if (action == "type_kehuan")//科幻
            {
                type_kehuan(context);
            }
            else if (action == "type_donghuapian")//动画片
            {
                type_donghuapian(context);
            }
            else if (action == "type_zhanzhengpian")//战争片
            {
                type_zhanzhengpian(context);
            }
            //else if (action == "Movie_pirce")//电影价格
            //{
            //    Movie_pirce(context);
            //}

        }
        ////电影价格
        //public void Movie_pirce(HttpContext context)
        //{
        //    DataTable dt = MovieBLL.BLL.selectall();

        //    string json = JsonConvert.SerializeObject(dt);
        //    context.Response.Write(json);
        //}
        //2017
        public void type_2017(HttpContext context)
        {
            DataTable dt = MovieBLL.BLL.select_year2017();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //2016
        public void type_2016(HttpContext context)
        {
            DataTable dt = MovieBLL.BLL.select_year2016();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //2015
        public void type_2015(HttpContext context)
        {
            DataTable dt = MovieBLL.BLL.select_year2015();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //香港
        public void type_xianggang(HttpContext context)
        {
            DataTable dt = MovieBLL.BLL.select_areaxianggang();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //中国
        public void type_zhonguo(HttpContext context)
        {
            DataTable dt = MovieBLL.BLL.select_areazhongguo();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //台湾
        public void type_taiwan(HttpContext context)
        {
            DataTable dt = MovieBLL.BLL.select_taiwan();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //美国
        public void type_meiguo(HttpContext context)
        {
            DataTable dt = MovieBLL.BLL.select_meiguo();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //韩国
        public void type_hanguo(HttpContext context)
        {
            DataTable dt = MovieBLL.BLL.select_hanguo();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //日本
        public void type_riben(HttpContext context)
        {
            DataTable dt = MovieBLL.BLL.select_riben();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //喜剧
        public void type_xiju(HttpContext context)
        {
            DataTable dt = MovieBLL.BLL.select_xiju();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //动作
        public void type_dongzuo(HttpContext context)
        {
            //context.Response.Write(Tool.ToJson(dblist));
            DataTable dt = MovieBLL.BLL.select_dongzuopian();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //爱情
        public void type_aiqing(HttpContext context)
        {
            //context.Response.Write(Tool.ToJson(dblist));
            DataTable dt = MovieBLL.BLL.select_aiqing();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //悬疑
        public void type_xuanyi(HttpContext context)
        {
            //context.Response.Write(Tool.ToJson(dblist));
            DataTable dt = MovieBLL.BLL.select_xuanyi();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //科幻
        public void type_kehuan(HttpContext context)
        {
            //context.Response.Write(Tool.ToJson(dblist));
            DataTable dt = MovieBLL.BLL.select_kehuan();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //动画片
        public void type_donghuapian(HttpContext context)
        {
            //context.Response.Write(Tool.ToJson(dblist));
            DataTable dt = MovieBLL.BLL.select_donghuapian();

            string json = JsonConvert.SerializeObject(dt);
            context.Response.Write(json);
        }
        //战争片
        public void type_zhanzhengpian(HttpContext context)
        {
            //context.Response.Write(Tool.ToJson(dblist));
            DataTable dt = MovieBLL.BLL.select_zhanzhengpian();

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