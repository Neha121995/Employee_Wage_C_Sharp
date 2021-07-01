using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_C_Sharp
{
    class UC5_CalculatingWagesForMonth
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public static void CalculatingWagesForMonth()
        {
            //vARIABLE
            int empHrs = 0, empwage = 0, totalempwage = 0;
            //Computation
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empwage = empHrs * EMP_RATE_PER_HOUR;
                totalempwage += empwage;
                Console.WriteLine("Emp Wage of day : " + (day + 1) + " is : " + empwage);
            }
            Console.WriteLine("Total Emp Wage : " + totalempwage);
        }
    }
}
