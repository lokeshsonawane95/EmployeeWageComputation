using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class PartTimeEmpWage
    {
        public void PartTime()
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int empRatePerHour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else if (empCheck == isPartTime)
            {
                Console.WriteLine("Employee is Part Time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
