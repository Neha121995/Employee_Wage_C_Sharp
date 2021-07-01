using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_C_Sharp
{
    class UC3_Part_Time_Employee_Wage
    {
        public static void PartTimeEmployeeWage()
        {
            //Constatnts
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_WAGE_PER_HOUR = 20;
            //Variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Emp wage is : " + empWage);
        }
    }
}
