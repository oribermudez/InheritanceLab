using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab.Classes
{
    /// <summary>
    /// Class that represents an employee
    /// </summary>
    /// <remarks>Author: Ori Bermudez </remarks>
    /// <remarks>Date: Jan 30, 2023 </remarks>
    internal class Employee
    {
        protected string id;
        protected string name;
        protected string address;
        protected string phone;
        protected long sin;
        protected string birthdate;
        protected string department;

        public string Id
        {
            get => id;
        }

        public string Name
        {
            get => name;
        }

        public virtual double Pay
        {
            get => 0;
        }

        /// <summary>
        /// User defined Employee class constructor
        /// </summary>
        /// <param name="id"> Holds the employee's ID </param>
        /// <param name="name"> Holds the employee's name </param>
        /// <param name="address"> Holds the employee's address </param>
        /// <param name="phone"> Holds the employee's phone </param>
        /// <param name="sin"> Holds the employee's sin </param>
        /// <param name="birthdate"> Holds the employee's birthdate </param>
        /// <param name="department"> Holds the employee's department </param>
        public Employee(string id, string name, string address, string phone, long sin, string birthdate, string department)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.birthdate = birthdate;
            this.department = department;
        }
    }
}
