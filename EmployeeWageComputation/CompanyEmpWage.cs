using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        //Declaring the methods which we have to define in EmpWageBuilderArray class
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth);
        public void ComputeEmpWage();
    }

    internal class CompanyEmpWage
    {
        //Using instance variables instead of parameters as per Use Case requirements
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHrsInMonth;
        public string company;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            //Setting values in class variables from constructor
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }

        //setting value of total employee wage
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        //Displaying wage by company
        public string DisplayEmpWage()
        {
            return "Total Emp Wage for company : " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
