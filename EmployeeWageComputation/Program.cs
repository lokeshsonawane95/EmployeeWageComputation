using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n 1. Employee Attendance");
                Console.WriteLine(" 2. Calculate Daily Employee Wage");
                Console.WriteLine(" 3. Part/Full time employee wage");
                Console.WriteLine(" 4. Part/Full time employee wage using switch case");
                Console.WriteLine(" 5. Calculation of wage for a month");
                Console.WriteLine(" 6. Calculation till total working hrs or days condition reached");
                Console.WriteLine(" 7. Calculation using class method and class variables");
                Console.WriteLine(" 8. Calculation for multiple companies");
                Console.WriteLine(" 9. Save total wage for each company");
                Console.WriteLine("10. Manage wage for multiple companies");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EmpAttendance empAttendance = new EmpAttendance();
                        empAttendance.Attendance();
                        break;
                    case 2:
                        CalcDailyEmpWage calcDailyEmpWage = new CalcDailyEmpWage();
                        calcDailyEmpWage.DailyWage();
                        break;
                    case 3:
                        PartTimeEmpWage partTimeEmpWage = new PartTimeEmpWage();
                        partTimeEmpWage.PartTime();
                        break;
                    case 4:
                        PTimeUsingSwitchCase pTimeUsingSwitchCase = new PTimeUsingSwitchCase();
                        pTimeUsingSwitchCase.PartTimeUsingSwitch();
                        break;
                    case 5:
                        CalcWageForMonth calcWageForMonth = new CalcWageForMonth();
                        calcWageForMonth.WageForMonth();
                        break;
                    case 6:
                        DayMonthCondition dayMonthCondition = new DayMonthCondition();
                        dayMonthCondition.Condition();
                        break;
                    case 7:
                        ClassMethodAndVars classMethodAndVars = new ClassMethodAndVars();
                        classMethodAndVars.EmpWage();
                        break;
                    case 8:
                        MultipleCompanies multipleCompanies = new MultipleCompanies();
                        multipleCompanies.Companies();
                        break;
                    case 9:
                        SaveWageForEachCompany save = new SaveWageForEachCompany();
                        save.SaveForEachCompany();
                        break;
                    case 10:
                        ManageMultipleCompanies manage = new ManageMultipleCompanies();
                        manage.ManageMultiple();
                        break;
                    default:
                        Console.WriteLine("Enter from the choices given");
                        break;
                }
            } while (choice != 0);
        }
    }
}