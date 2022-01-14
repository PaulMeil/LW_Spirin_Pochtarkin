using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackToTheFuture.Models
{
    public class OutputData
    {
        public double[] chooses { get; set; } = new double[5];
        public int border1 { get; set; }
        public int border2 { get; set; }
        public int border3 { get; set; }
        public double[] uncoveredArea { get; set; } = new double[5];
        public double totalUncoveredArea { get; set; }
    }
}