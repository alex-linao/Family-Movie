using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Data;

namespace WebApplication2
{
    /// <summary>
    /// tuijian7_shouye 的摘要说明
    /// </summary>
    public class tuijian7_shouye : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            DataTable dt = MovieBLL.BLL.select();
            List<MovieModel.MovieModel> aa = new List<MovieModel.MovieModel>();
            foreach (DataRow item in dt.Rows)
            {
                MovieModel.MovieModel a = new MovieModel.MovieModel();
                a.MovieID = int.Parse(item["MovieID"].ToString());
                a.MovieNAME = item["MovieNAME"].ToString();
                a.MovieADDtime = int.Parse(item["MovieADDtime"].ToString());
                a.MovieLength = item["MovieLength"].ToString();
                a.MoviePath = item["MoviePath"].ToString();
                a.MoviePrice = item["MoviePrice"].ToString();
                a.MovieStarring = item["MovieStarring"].ToString();
                a.MovieTypeID = int.Parse(item["MovieTypeID"].ToString());
                a.MovieImg = item["MovieImg"].ToString();
                aa.Add(a);
            }
            string json = JsonConvert.SerializeObject(aa);
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