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
            // Relative path to employees.txt file
            string path = "employees.txt";

            // Get lines/rows in file as string array
            string[] lines = File.ReadAllLines(path);

            // Create list that holds any type of Employee
            List<Employee> employees = new List<Employee>();
        }
    }
}
