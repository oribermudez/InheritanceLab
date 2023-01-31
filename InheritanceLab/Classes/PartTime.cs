using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab.Classes
{
    /// <summary>
    /// Class that represents a part-time employee
    /// </summary>
    /// <remarks>Author: Ori Bermudez </remarks>
    /// <remarks>Date: Jan 30, 2023 </remarks>
    internal class PartTime : Employee
    {
        private double rate;
        private double hours;

        public double Rate
        {
            get => rate;
        }

        public double Hours
        {
            get => hours;
        }

        public override double Pay
        {
            get
            {
                double rate = this.Rate;
                double hours = this.Hours;

                double pay = rate * hours;

                return pay;
            }
        }

        /// <summary>
        /// User-defined PartTime class constructor
        /// </summary>
        /// <param name="rate"> Holds the employee's hour rate </param>
        /// <param name="hours"> Holds the number of hours worked </param>
        public PartTime(double rate, double hours)
        {
            this.rate = rate;
            this.hours = hours;
        }
    }
}
