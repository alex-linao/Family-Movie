using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieModel
{
    public class MovieModel
    {
        public int MovieID { get; set; }
        public string MovieNAME { get; set; }
        public int MovieADDtime { get; set; }
        public string MovieLength { get; set; }
        public string MoviePrice { get; set; }
        public string MovieStarring { get; set; }
        public int MovieTypeID { get; set; }
        public int MovieAreaID { get; set; }
        public string MoviePath { get; set; }
        public string MovieImg { get; set; }
        public string AreaName { get; set; }
        public string MovieTypeNAME { get; set; }
        public string VIPname { get; set; }
        public int IsVIP { get; set; }
    }
}
