using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class Data
    {
        public string FN { get; set; }
        public string LN { get; set; } 
        public string UN { get; set; }
        public string PW { get; set; }

        public Data(string FN, string LN, string PW, string UN)
        {
            this.FN = FN;
            this.LN = LN;
            this.PW = PW;
            this.UN = UN;
        }
    }
}
