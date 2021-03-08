using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace MovieBLL
{
   public  class BLL 
    {
        //查询订单表——后台
       public static DataTable chaxundingdan_H()
        {
            return MovieDAL.DAL.chaxundingdan_H();

        }
        //查询用户是否购买了其点击的电影
       public static DataTable select_or_dingdan(string a, string b)
        {
            return MovieDAL.DAL.select_or_dingdan(a,b);

        }
       //加钱
       public static bool jiaqian(string a, string b)
       {
           return MovieDAL.DAL.jiaqian(a, b);
       }
        //扣钱
        public static bool kouqian(string a,string b)
        {
            return MovieDAL.DAL.kouqian(a,b);
        }
        //添加信息
        public static bool tianjiadingdan(MovieModel.OrderModel aa)
        {
            return MovieDAL.DAL.tianjiadingdan(aa);
        }
        //通过传入值修改电影信息
        public static bool updateMovies(MovieModel.MovieModel aa)
        {
            return MovieDAL.DAL.updatemovies(aa);
        }
        //充值
        public static bool chongzhi(string a,string b)
        {
            return MovieDAL.DAL.chongzhi(a,b);
        }
        //删除订单
        public static bool delete_dingdan(string aa)
        {
            return MovieDAL.DAL.delete_dingdan(aa);
        }
       //批量删除
       public static bool delete(string sql1)
       {
           return MovieDAL.DAL.delete(sql1);
       }
        //注册
       public static bool insertMovies(MovieModel.MovieModel aa)
       {
           return MovieDAL.DAL.insertMovies(aa);
       }
       //判断用户名密码
       public static DataTable yonghuingmima(MovieModel.UserModel aa)
       {
           return MovieDAL.DAL.yonghumingmima(aa);

       }

       //注册
       public static bool zhuce(MovieModel.UserModel aa)
       {
           return MovieDAL.DAL.zhuce(aa);
       }
        //查询一个电影资源价格
        public static DataTable selectall(string a)
        {
            return MovieDAL.DAL.selectall(a);
        }
        //通过传入用户ID查询订单表
        public static DataTable selectall_user_dingdanbiao(string a)
        {
            return MovieDAL.DAL.selectall_user_dingdanbiao(a);
        }
        //通过传入用户ID查询用户信息
        public static DataTable selectall_user_gerenziliao(string a)
        {
            return MovieDAL.DAL.selectall_user_gerenziliao(a);
        }
        //查询所有用户信息
        public static DataTable selectall_user()
        {
            return MovieDAL.DAL.selectall_user();
        }
        //查询所有电影资源信息
        public static DataTable selectAll()
        {
            return MovieDAL.DAL.selectAll();
        }
        //查询电影资源信息——首页动漫 8 个
        public static DataTable select8_dongman()
        {
            return MovieDAL.DAL.select8_dongman();
        }
        //查询电影资源信息——首页综艺 8 个
        public static DataTable select8_zongyi()
        {
            return MovieDAL.DAL.select8_zongyi();
        }
        //查询电影资源信息——首页动作 8 个
        public static DataTable select8_dongzuo()
        {
            return MovieDAL.DAL.select8_dongzuo();
        }
        //查询电影资源信息——首页科幻 8 个
        public static DataTable select8()
        {
            return MovieDAL.DAL.select8();
        }
        //查询前7个电影资源信息
       public static DataTable select()
       {
           return MovieDAL.DAL.select();
       }
       //查询电影类型——喜剧
       public static DataTable select_xiju()
       {
           return MovieDAL.DAL.select_xiju();
       }
       //查询电影类型——动作片
       public static DataTable select_dongzuopian()
       {
           return MovieDAL.DAL.select_dongzuopian();
       }
       //查询电影类型——爱情
       public static DataTable select_aiqing()
       {
           return MovieDAL.DAL.select_aiqing();
       }
       //查询电影类型——悬疑
       public static DataTable select_xuanyi()
       {
           return MovieDAL.DAL.select_xuanyi();
       }
       //查询电影类型——科幻
       public static DataTable select_kehuan()
       {
           return MovieDAL.DAL.select_kehuan();
       }
       //查询电影类型——动画片
       public static DataTable select_donghuapian()
       {
           return MovieDAL.DAL.select_donghuapian();
       }
       //查询电影类型——战争片
       public static DataTable select_zhanzhengpian()
       {
           return MovieDAL.DAL.select_zhanzhengpian();
       }
       //查询电影地区——中国
       public static DataTable select_areazhongguo()
       {
           return MovieDAL.DAL.select_areazhongguo();
       }
       //查询电影地区——香港
       public static DataTable select_areaxianggang()
       {
           return MovieDAL.DAL.select_areaxianggang();
       }
       //查询电影地区——台湾
       public static DataTable select_taiwan()
       {
           return MovieDAL.DAL.select_taiwan();
       }
       //查询电影地区——美国
       public static DataTable select_meiguo()
       {
           return MovieDAL.DAL.select_meiguo();
       }
       //查询电影地区——韩国
       public static DataTable select_hanguo()
       {
           return MovieDAL.DAL.select_hanguo();
       }
       //查询电影地区——日本
       public static DataTable select_riben()
       {
           return MovieDAL.DAL.select_riben();
       }
       //查询电影年份——2017
       public static DataTable select_year2017()
       {
           return MovieDAL.DAL.select_year2017();
       }
       //查询电影年份——2016
       public static DataTable select_year2016()
       {
           return MovieDAL.DAL.select_year2016();
       }
       //查询电影年份——2015
       public static DataTable select_year2015()
       {
           return MovieDAL.DAL.select_year2015();
       }
       //查询条件——传值
       public static DataTable select_tiaojian(string a)
       {
           return MovieDAL.DAL.select_tiaojian(a);
       }
       //查询条件——传值用户
       public static DataTable select_user_chuanzhi(string a)
       {
           return MovieDAL.DAL.select_user_chuanzhi(a);
       }
    }
}
