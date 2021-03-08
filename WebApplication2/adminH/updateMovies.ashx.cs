using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;

namespace WebApplication2.adminH
{
    /// <summary>
    /// updateMovies 的摘要说明
    /// </summary>
    public class updateMovies : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string MovieID = context.Request["MovieID"].ToString();
            string MovieNAME = context.Request["MovieNAME"].ToString();
            string MovieADDtime = context.Request["MovieADDtime"].ToString();
            string MoviePrice = context.Request["MoviePrice"].ToString();
            string MovieStarring = context.Request["MovieStarring"].ToString();
            string MovieTypeID = context.Request["MovieTypeID"].ToString();
            string MovieAreaID = context.Request["MovieAreaID"].ToString();
            string MovieLength = context.Request["MovieLength"].ToString();
            //string MovieImg = context.Request["MovieImg"].ToString();
            //视频
            HttpPostedFile file2 = context.Request.Files["MoviePath1"];
            FileInfo fi2 = new FileInfo(file2.FileName);
            //扩展名
            string fil2 = fi2.Extension;
            //时间名
            string kz2 = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            string newpath2 = context.Server.MapPath(".") + "\\../MP4\\" + kz2 + fil2;

            file2.SaveAs(newpath2);
            string newpathmp4 = "\\../MP4\\" + kz2 + fil2;
            //封面
            HttpPostedFile file = context.Request.Files["MovieImg1"];
            FileInfo fi = new FileInfo(file.FileName);
            //扩展名
            string fil = fi.Extension;
            //时间名
            string kz = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            string newpath = context.Server.MapPath(".") + "\\../static\\images\\" + kz + fil;

            file.SaveAs(newpath);
            string newimages = "..\\static\\images\\" + kz + fil;




            MovieModel.MovieModel aa = new MovieModel.MovieModel();
            aa.MovieID = int.Parse(MovieID);
            aa.MoviePath = newpathmp4;
            aa.MovieNAME = MovieNAME;
            aa.MovieADDtime = int.Parse(MovieADDtime);
            aa.MoviePrice = MoviePrice;
            aa.MovieStarring = MovieStarring;
            aa.MovieTypeID = int.Parse(MovieTypeID);
            aa.MovieAreaID = int.Parse(MovieAreaID);
            aa.MovieLength = MovieLength;
            aa.MovieImg = newimages;
            bool isucc = MovieBLL.BLL.updateMovies(aa);

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