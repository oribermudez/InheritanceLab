using InheritanceLab.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InheritanceLab
{
    internal class Program
    {
        static void Main(string[] args)
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

                string firstIdDigit = id.Substring(0, 1);
                int firstIdDigitNum = int.Parse(firstIdDigit);

                bool isSalaried = firstIdDigitNum >= 0 && firstIdDigitNum <= 4;
                bool isWaged = firstIdDigitNum >= 5 && firstIdDigitNum <= 7;
                bool isPartTime = firstIdDigitNum >= 8 && firstIdDigitNum <= 9;

                if (isSalaried)
                {
                    double salary = double.Parse(employeeData[7]);

                    Salaried salaried = new Salaried(id, name, address, phone, sin, birthdate, department, salary);

                    employees.Add(salaried);
                }
                else if (isWaged)
                {
                    double rate = double.Parse(employeeData[7]);
                    double hours = double.Parse(employeeData[8]);

                    Waged waged = new Waged(id, name, address, phone, sin, birthdate, department, rate, hours);

                    employees.Add(waged);
                }
                else if (isPartTime)
                {
                    double rate = double.Parse(employeeData[7]);
                    double hours = double.Parse(employeeData[8]);

                    PartTime partTime = new PartTime(id, name, address, phone, sin, birthdate, department, rate, hours);

                    employees.Add(partTime);
                }
            }
        }
    }
}
