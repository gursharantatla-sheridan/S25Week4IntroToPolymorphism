using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class CommissionEmployee : Employee
    {
        public double GrossSales { get; set; }
        public double CommRate { get; set; }

        public CommissionEmployee(int id, string name, double grossSales, double commRate) : base(id, name)
        {
            GrossSales = grossSales;
            CommRate = commRate;
        }

        public override double Earnings()
        {
            return GrossSales * CommRate;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nGross Sales = {GrossSales:C}\nCommission Rate = {CommRate:P}";
        }
    }
}
