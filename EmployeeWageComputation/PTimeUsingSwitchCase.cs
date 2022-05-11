using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class PTimeUsingSwitchCase
    {
        public void PartTimeUsingSwitch()
        {
            const int isFullTime = 1;
            const int isPartTime = 2;
            int empRatePerHour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case isFullTime:
                    Console.WriteLine("Employee is Present and is Full Time");
                    empHrs = 8;
                    break;
                case isPartTime:
                    Console.WriteLine("Employee is Present and is Part Time");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
