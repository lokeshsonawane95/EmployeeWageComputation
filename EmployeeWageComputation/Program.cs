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
                Console.WriteLine("\n1. Employee Attendance");
                Console.WriteLine("2. Calculate Daily Employee Wage");

                Console.WriteLine("0. Exit");
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
                }
            } while (choice != 0);
        }
    }
}