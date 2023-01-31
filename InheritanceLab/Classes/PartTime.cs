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
        /// <param name="id"> Holds the employee's ID </param>
        /// <param name="name"> Holds the employee's name </param>
        /// <param name="address"> Holds the employee's address </param>
        /// <param name="phone"> Holds the employee's phone </param>
        /// <param name="sin"> Holds the employee's sin </param>
        /// <param name="birthdate"> Holds the employee's birthdate </param>
        /// <param name="department"> Holds the employee's department </param>
        /// <param name="rate"> Holds the employee's hour rate </param>
        /// <param name="hours"> Holds the number of hours worked </param>
        public PartTime(string id, string name, string address, string phone, long sin, string birthdate, string department, double rate, double hours)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.birthdate = birthdate;
            this.department = department;
            this.rate = rate;
            this.hours = hours;
        }
    }
}
