using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmpWageBuilderArray : IComputeEmpWage
    {
        const int isFullTime = 1;
        const int isPartTime = 2;

        //int numOfCompany = 0;
        //Declaring companyEmpWage
        public List<CompanyEmpWage> companyEmpWageList;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageList = new List<CompanyEmpWage>();
        }

        //Execution starts here
        //Values are passed to the instance
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHrsInMonth);
            this.companyEmpWageList.Add(companyEmpWage);

            //companyEmpWageArrayList[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHrsInMonth);

            //After values passed to a particular instance the index numOfCompany increses
            //numOfCompany++;
        }

        //Passing each instance separately for calculation
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in companyEmpWageList)
            {
                //Passing each instance for further calcuation
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));

                //Displaying values calculated for each instance
                Console.WriteLine(companyEmpWage.DisplayEmpWage());
            }
            /*for (int i = 0; i < numOfCompany; i++)
            {
                //Passing each instance for further calculation
                companyEmpWageArrayList[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArrayList[i]));

                //Displaying values calculated for each instance
                Console.WriteLine(this.companyEmpWageArrayList[i].DisplayEmpWage());
            }*/
        }

        //Actual calculation logic
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs < companyEmpWage.maxHrsInMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                //Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }

    //Creating driver code class in same file to prevent ambiguity
    internal class ManageMultipleCompanies
    {
        public void ManageMultiple()
        {
            //We are passing values directly to the constructor
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();

            //Passing values to AddCompanyEmpWage method for further calculation
            empWageBuilder.AddCompanyEmpWage("Microsoft", 32, 22, 110);
            empWageBuilder.AddCompanyEmpWage("Google", 38, 20, 100);

            empWageBuilder.ComputeEmpWage();
        }
    }
}
