using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_C_Sharp
{
    class UC1_Employee_Attendence
    {
        public static void empCheck()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
    }
}
