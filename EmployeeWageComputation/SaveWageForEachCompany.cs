using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    //Created 2 class in a single file to prevent ambiguity

    //EmpWageBuilder class for calculation as per Use Case requirements
    internal class EmpWageBuilder
    {
        const int isFullTime = 1;
        const int isPartTime = 2;

        //Using instance variables instead of parameters as per Use Case requirements
        int empRatePerHour;
        int numOfWorkingDays;
        int maxHrsInMonth;
        string company;
        int totalEmpWage;

        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            //Setting values in class variables from constructor
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }

        //Calculation logic
        public void EmpWage()
        {
            int empHrs;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            //While employee is working less than max hours in a month as well as number of working days of a month
            while (totalEmpHrs < this.maxHrsInMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);

                //If total hours equals to max working hours in a month
                if (totalEmpHrs == this.maxHrsInMonth)
                {
                    Console.WriteLine("Total working hours condition has reached i.e. " + this.maxHrsInMonth + " hrs");
                }

                //If total working days equals to number of working days of a month
                if (totalWorkingDays == this.numOfWorkingDays)
                {
                    Console.WriteLine("Total working days condition has reached i.e. " + this.numOfWorkingDays + " days");
                }
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            //Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }

        //Displaying wage by each company
        public string DisplayEmpWage()
        {
            return "Total Emp Wage for company : " + this.company + " is : " + this.totalEmpWage;
        }
    }

    internal class SaveWageForEachCompany
    {
        public void SaveForEachCompany()
        {
            //We are passing values directly to the constructor
            EmpWageBuilder empMicrosoft = new EmpWageBuilder("Microsoft", 32, 20, 100);
            EmpWageBuilder empGoogle = new EmpWageBuilder("Google", 38, 20, 100);

            //Calculating Wage for each employee
            empMicrosoft.EmpWage();

            //Displaying total wage of employees
            Console.WriteLine(empMicrosoft.DisplayEmpWage());

            empGoogle.EmpWage();
            Console.WriteLine(empGoogle.DisplayEmpWage());
        }
    }
}
