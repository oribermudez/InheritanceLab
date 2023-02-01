using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InheritanceLab.Classes
{
    internal class EmployeeManager
    {
        private readonly List<Employee> employeesList;

        public EmployeeManager()
        {
            string path = "employees.txt";

            string[] lines = File.ReadAllLines(path);

            List<Employee> employees = new List<Employee>();

            foreach (string line in lines)
            {
                string[] employeeData = line.Split(':');

                string id = employeeData[0];
                string name = employeeData[1];
                string address = employeeData[2];
                string phone = employeeData[3];
                long sin = long.Parse(employeeData[4]);
                string birthdate = employeeData[5];
                string department = employeeData[6];

                string firstIdChar = id.Substring(0, 1);
                int firstIdDigit = int.Parse(firstIdChar);

                bool isSalaried = firstIdDigit >= 0 && firstIdDigit <= 4;
                bool isWaged = firstIdDigit >= 5 && firstIdDigit <= 7;
                bool isPartTime = firstIdDigit >= 8 && firstIdDigit <= 9;

                if (isSalaried)
                {
                    double salary = double.Parse(employeeData[7]);
                    Salaried salaried = new Salaried(id, name, address, phone, sin, birthdate, department, salary);
                    employees.Add(salaried);
                }
                else
                {
                    double rate = double.Parse(employeeData[7]);
                    double hours = double.Parse(employeeData[8]);

                    if (isWaged)
                    {
                        Waged waged = new Waged(id, name, address, phone, sin, birthdate, department, rate, hours);
                        employees.Add(waged);
                    }
                    else if (isPartTime)
                    {

                        PartTime partTime = new PartTime(id, name, address, phone, sin, birthdate, department, rate, hours);
                        employees.Add(partTime);
                    }
                }

            }
            this.employeesList= employees;
        }

        public double GetAverageWeeklyPay()
        {
            double weeklyPay = 0;

            foreach (Employee employee in this.employeesList)
            {
                if (employee is PartTime partTime)
                {
                    weeklyPay += partTime.Pay;
                }
                else if (employee is Waged waged)
                {
                    weeklyPay += waged.Pay;
                }
                else if (employee is Salaried salaried)
                {
                    weeklyPay += salaried.Pay;
                }
            }

            double averageWeeklyPay = weeklyPay / this.employeesList.Count;

            return averageWeeklyPay;
        }

        public Waged GetHighestPaid()
        {
            double highestWagedPay = 0;
            Waged highestWagedEmployee = null;

            foreach (Employee employee in this.employeesList)
            {
                if (employee is Waged waged)
                {
                    double pay = waged.Pay;

                    if (pay > highestWagedPay)
                    {
                        highestWagedPay = pay;
                        highestWagedEmployee = waged;
                    }
                }
            }

            return highestWagedEmployee;
        }

        public Salaried GetLowestPaid()
        {
            double lowestSalariedPay = double.MaxValue;
            Salaried lowestSalariedEmployee = null;

            foreach (Employee employee in this.employeesList)
            {
                if (employee is Salaried salaried)
                {
                    double pay = salaried.Pay;

                    if (pay < lowestSalariedPay)
                    {
                        lowestSalariedPay = pay;
                        lowestSalariedEmployee = salaried;
                    }
                }
            }

            return lowestSalariedEmployee;
        }

        public double[] GetCategoryPercentages()
        {
            double partTimeEmployees = 0;
            double wagedEmployees = 0;
            double salariedEmployees = 0;

            foreach (Employee employee in this.employeesList)
            {
                if (employee is PartTime partTime)
                {
                    partTimeEmployees += 1;
                }
                else if (employee is Waged waged)
                {
                    wagedEmployees += 1;
                }
                else if (employee is Salaried salaried)
                {
                    salariedEmployees += 1;
                }
            }

            double partTimePercentage = (partTimeEmployees / this.employeesList.Count) * 100;
            double wagedPercentage = (wagedEmployees / this.employeesList.Count) * 100;
            double salariedPercentage = (salariedEmployees / this.employeesList.Count) * 100;

           double[] percentages = { partTimePercentage, wagedPercentage, salariedPercentage };

            return percentages;
        }
    }
}
