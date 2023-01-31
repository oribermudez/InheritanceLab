using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab.Classes
{
    /// <summary>
    /// Class that represents a salaried employee
    /// </summary>
    /// <remarks>Author: Ori Bermudez </remarks>
    /// <remarks>Date: Jan 30, 2023 </remarks>
    internal class Salaried :  Employee
    {
        private double salary;

        public double Salary
        {
            get => salary;
        }

        public override double Pay
        {
            get => salary;
        }


        /// <summary>
        /// User-defined Salaried class constructor
        /// </summary>
        /// <param name="id"> Holds the employee's ID </param>
        /// <param name="name"> Holds the employee's name </param>
        /// <param name="address"> Holds the employee's address </param>
        /// <param name="phone"> Holds the employee's phone </param>
        /// <param name="sin"> Holds the employee's sin </param>
        /// <param name="birthdate"> Holds the employee's birthdate </param>
        /// <param name="department"> Holds the employee's department </param>
        /// <param name="salary"> Holds the employee's salary </param>
        public Salaried(string id, string name, string address, string phone, long sin, string birthdate, string department, double salary) : base(id, name, address, phone, sin, birthdate, department)
        {
            this.salary = salary;
        }
    }
}
