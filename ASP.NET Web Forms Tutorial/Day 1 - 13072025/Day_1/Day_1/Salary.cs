using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day_1
{
    [Serializable]
    public class Salary
    {
        public double basic;
        public double rentPerc;
        public double medicalPerc;

        public double CalculateSalary()
        {
            double rent = basic*(rentPerc/100);
            double medical = basic*(medicalPerc/100);

            double total = basic + rent + medical;

            return total;
        }
    }
}