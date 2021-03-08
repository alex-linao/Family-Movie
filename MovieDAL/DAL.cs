using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace MovieDAL
{
    public class DAL
    {
        //查询用户是否购买了其点击的电影
        public static DataTable select_or_dingdan(string a, string b)
        {

            string sql = string.Format("select * from OrderTable o,UserTable u, MovieinfoTable m  where o.MovieID=m.MovieID and u.UserID=o.UserID and m.MovieID='{0}' and u.UserNumber='{1}'", a, b);
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //扣钱
        public static bool kouqian(string a, string b)
        {
            string sql = string.Format("update UserTable set Balance-={0} where UserID ='{1}'", a, b);
            bool isucc = DBHelper.en(sql);
            return isucc;
        }
        //退票加钱
        public static bool jiaqian(string a, string b)
        {
            string sql = string.Format("update UserTable set Balance+={0} where UserNumber='{1}'", a, b);
            bool isucc = DBHelper.en(sql);
            return isucc;
        }
        //添加订单信息
        public static bool tianjiadingdan(MovieModel.OrderModel aa)
        {
            string sql = string.Format("insert OrderTable(OrderGenerateTime,UserID,OrderPrice,MovieID) values('{0}','{1}','{2}','{3}')", aa.OrderGenerateTime, aa.UserID, aa.OrderPrice, aa.MovieID);
            bool isucc = DBHelper.en(sql);
            return isucc;
        }
        //充值按钮
        public static bool chongzhi(string a, string b)
        {
            string sql = string.Format("update UserTable set Balance+={0} where UserNumber='{1}'", a, b);
            bool isucc = DBHelper.en(sql);
            return isucc;
        }
        //修改传入的电影信息
        public static bool updatemovies(MovieModel.MovieModel aa)
        {
            string sql = string.Format("update MovieinfoTable set MovieNAME='{0}',MovieTypeID='{1}',MovieADDtime='{2}',MovieStarring='{3}',MovieLength='{4}',MovieAreaID='{5}',MoviePath='{6}',MoviePrice='{7}',MovieImg='{8}'where MovieID='{9}'", aa.MovieNAME, aa.MovieTypeID, aa.MovieADDtime, aa.MovieStarring, aa.MovieLength, aa.MovieAreaID, aa.MoviePath, aa.MoviePrice, aa.MovieImg, aa.MovieID);
            bool isucc = DBHelper.en(sql);
            return isucc;
        }
        //删除订单信息
        public static bool delete_dingdan(string aa)
        {
            string sql = string.Format("delete from OrderTable where OrderID={0}", aa);
            bool isucc = DBHelper.en(sql);
            return isucc;
        }
        //添批量删除
        public static bool delete(string sql1)
        {
            string sql = string.Format("delete from MovieinfoTable where {0}", sql1);
            bool isucc = DBHelper.en(sql);
            return isucc;
        }
        //添加电影信息
        public static bool insertMovies(MovieModel.MovieModel aa)
        {
            string sql = string.Format("insert into MovieinfoTable(MovieNAME,MovieADDtime,MoviePrice,MovieStarring,MoviePath,MovieImg,MovieAreaID,MovieTypeID,MovieLength) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", aa.MovieNAME, aa.MovieADDtime, aa.MoviePrice, aa.MovieStarring, aa.MoviePath, aa.MovieImg, aa.MovieAreaID, aa.MovieTypeID, aa.MovieLength);
            bool isucc = DBHelper.en(sql);
            return isucc;
        }
        //查询订单表——后台
        public static DataTable chaxundingdan_H()
        {
            string sql = string.Format("select* from OrderTable o,UserTable u,MovieinfoTable m where o.MovieID=m.MovieID and o.UserID=u.UserID ");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //判断用户名密码
        public static DataTable yonghumingmima(MovieModel.UserModel aa)
        {
            string sql = string.Format("select  * from UserTable where UserNumber='{0}' and UserPwd = '{1}'", aa.UserNumber, aa.UserPwd);
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //注册
        public static bool zhuce(MovieModel.UserModel aa)
        {
            string sql = string.Format("insert into UserTable(UserNumber,UserPwd,UserName,UserSex,UserTel,UserAge,Balance) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", aa.UserNumber, aa.UserPwd, aa.UserName, aa.UserSex, aa.UserTel, aa.UserAge, aa.Balance);
            bool isucc = DBHelper.en(sql);
            return isucc;
        }
        //通过传入电影ID来查询该电影所有信息
        public static DataTable selectall(string a)
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID and MovieID='{0}'", a);
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //通过传入用户ID查询订单信息表
        public static DataTable selectall_user_dingdanbiao(string a)
        {

            string sql = string.Format("select* from OrderTable o,UserTable u,MovieinfoTable m where o.MovieID=m.MovieID and o.UserID=u.UserID  and u.UserNumber='{0}'", a);
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //通过传入用户ID查询用户信息
        public static DataTable selectall_user_gerenziliao(string a)
        {

            string sql = string.Format("select * from UserTable where UserNumber='{0}'", a);
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询所有用户信息
        public static DataTable selectall_user()
        {

            string sql = string.Format("select * from UserTable");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询所有电影资源信息
        public static DataTable selectAll()
        {

            string sql = string.Format("select * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影资源信息——首页动漫 8 个
        public static DataTable select8_dongman()
        {

            string sql = string.Format("select top 8 * from MovieinfoTable where MovieTypeID='9'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影资源信息——首页综艺 8 个
        public static DataTable select8_zongyi()
        {

            string sql = string.Format("select top 8 * from MovieinfoTable where MovieTypeID='8'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影资源信息——首页动作 8 个
        public static DataTable select8_dongzuo()
        {

            string sql = string.Format("select top 8 * from MovieinfoTable where MovieTypeID='7'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影资源信息——首页科幻 8 个
        public static DataTable select8()
        {

            string sql = string.Format("select top 8 * from MovieinfoTable where MovieTypeID='4'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询前7个电影资源信息
        public static DataTable select()
        {

            string sql = string.Format("select top 7 * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影类型——喜剧
        public static DataTable select_xiju()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID  and MovieTypeNAME='喜剧' ");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影类型——动作片
        public static DataTable select_dongzuopian()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID  and MovieTypeNAME='动作' ");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影类型——爱情
        public static DataTable select_aiqing()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID  and MovieTypeNAME='爱情' ");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影类型——恐怖
        public static DataTable select_xuanyi()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID  and MovieTypeNAME='悬疑' ");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影类型——科幻
        public static DataTable select_kehuan()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID  and MovieTypeNAME='科幻' ");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影类型——动画片
        public static DataTable select_donghuapian()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID  and MovieTypeNAME='动漫' ");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影类型——战争片
        public static DataTable select_zhanzhengpian()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID  and MovieTypeNAME='战争' ");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影地区——中国
        public static DataTable select_areazhongguo()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2  where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID and AreaName='中国'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影地区——香港
        public static DataTable select_areaxianggang()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2  where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID and AreaName='香港'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影地区——台湾
        public static DataTable select_taiwan()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2  where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID and AreaName='台湾'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影地区——美国
        public static DataTable select_meiguo()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2  where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID and AreaName='美国'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影地区——韩国
        public static DataTable select_hanguo()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2  where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID and AreaName='韩国'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影地区——日本
        public static DataTable select_riben()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2  where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID and AreaName='日本'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影年份——2017
        public static DataTable select_year2017()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2  where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID  and MovieADDtime='2017'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影年份——2016
        public static DataTable select_year2016()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID  and MovieADDtime='2016'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //查询电影年份——2015
        public static DataTable select_year2015()
        {

            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2 where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID  and MovieADDtime='2015'");
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //传值查询搜索页面
        public static DataTable select_tiaojian(string a)
        {
            string sql = string.Format("select  * from MovieinfoTable m,MoveAreaTable m1,MovieType m2  where m.MovieTypeID=m2.MovieTypeID and m.MovieAreaID=m1.MovieAreaID and MovieNAME like '%{0}%'", a);
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //传值查询搜索页面_用户
        public static DataTable select_user_chuanzhi(string a)
        {
            string sql = string.Format("select * from UserTable where UserName like'%{0}%'", a);
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
    }
}
