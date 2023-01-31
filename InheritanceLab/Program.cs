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
            EmployeeManager manager = new EmployeeManager();

            double averageWeeklyPay = manager.GetAverageWeeklyPay();
            Console.WriteLine(string.Format("Average weekly pay: {0:C2}", averageWeeklyPay));

            Employee highestPaidWagedEmployee = manager.GetHighestPaid();
            double highestWagedPay = highestPaidWagedEmployee.Pay;
            Console.WriteLine("Highest waged pay: " + highestWagedPay.ToString("C2"));
            Console.WriteLine("Highest waged employee: " + highestPaidWagedEmployee.Name);

            Employee lowestPaidSalariedEmployee = manager.GetLowestPaid();
            double lowestSalariedPay = lowestPaidSalariedEmployee.Pay;
            Console.WriteLine("Lowest salaried pay: " + lowestSalariedPay.ToString("C2"));
            Console.WriteLine("Lowest salaried employee: " + lowestPaidSalariedEmployee.Name);

            double[] percentages = manager.GetCategoryPercentages();
            Console.WriteLine("Salaried employees percentage: " + percentages[2].ToString("N2") + "%");
            Console.WriteLine("Waged employees percentage: " + percentages[1].ToString("N2") + "%");
            Console.WriteLine("Part time employees percentage: " + percentages[0].ToString("N2") + "%");
        }
    }
}
