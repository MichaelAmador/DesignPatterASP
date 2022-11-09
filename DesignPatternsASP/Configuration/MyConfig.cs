using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASP.Configuration
{
    public class MyConfig
    {
        public string PathLog { get; set; }
        public decimal LocalPercenatge { get; set; }
        public decimal ForeignPercentage { get; set; }
        public decimal Extra { get; set; }
    }
}
