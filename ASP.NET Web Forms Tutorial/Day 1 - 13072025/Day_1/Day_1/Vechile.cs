using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day_1
{
    [Serializable]
    public class Vechile
    {
        public string name;
        public string regNo;
        public List<double> speedList;

        public double getMin()
        {
            return speedList.Min();
        }

        public double getMax()
        {
            return speedList.Max();
        }

        public double getAvg()
        {
            return speedList.Average();
        }
    }
}