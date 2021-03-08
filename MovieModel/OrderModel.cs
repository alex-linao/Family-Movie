using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieModel
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        public string OrderGenerateTime { get; set; }
        public int UserID { get; set; }
        public string OrderPrice { get; set; }
        public int MovieID { get; set; }

    }
}
