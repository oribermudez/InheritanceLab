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
        /// No-argument Employee class constructor
        /// </summary>
        public Employee()
        {
        }
    }
}
