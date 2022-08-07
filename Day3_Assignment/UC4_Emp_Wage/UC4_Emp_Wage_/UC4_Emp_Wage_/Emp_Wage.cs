using System;
using System.Collections.Generic;
using System.Text;

namespace UC4_Emp_Wage_
{
    class Emp_Wage
    {

        public const int Is_Fulltime = 1;
        public const int Is_Parttime = 2;


        public void MultipleCompnies(string company, int Emp_Hrs_Rate, int Num_of_Working_Days, int Max_Hrs_In_Month)
        {
            int Emp_Hours;
            int Emp_Wage;
            // int Total_Emp_Wage = 0;
            int Total_Emp_Hrs = 0;
            int Total_Working_Day = 0;

             
            while (Total_Emp_Hrs <= Max_Hrs_In_Month && Total_Working_Day <= Num_of_Working_Days)
            {
                Total_Working_Day++;
                Random random = new Random();
                int emp_type = random.Next(0, 3);

                switch (emp_type)
                {
                    case Is_Fulltime:
                        Emp_Hours = 8;
                        break;
                    case Is_Parttime:
                        Emp_Hours = 4;
                        break;
                    default:
                        Emp_Hours = 0;
                        break;
                }

                Total_Emp_Hrs = Emp_Hours + Total_Emp_Hrs;


                Console.WriteLine("Emp_Hours:" + Emp_Hours);
                Console.WriteLine("Total_Working_Day:" + Total_Working_Day);
            }
            Emp_Wage = Total_Emp_Hrs * Emp_Hrs_Rate;
            Console.WriteLine("Total_Emp_Wage of Company:" + company + Emp_Wage);
        }
    }
}
