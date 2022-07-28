using System;

namespace UC4_Emp_Wage_
{
    class Program
    {
        public const int Is_Fulltime = 1;
        public const int Is_Parttime = 2;

        public const int Emp_Hrs_Rate = 25;
        public const int Num_of_Working_Days = 26;



        static void Main(string[] args)
        {
            int Emp_Hours;
            int Emp_Wage;
            int Total_Emp_Wage=0;

            for(int days=0; days < Num_of_Working_Days; days++) 
            {

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

                Emp_Wage = Emp_Hours * Emp_Hrs_Rate;
                Total_Emp_Wage = Emp_Wage + Total_Emp_Wage;

                Console.WriteLine("Emp_Type:" + emp_type);
                Console.WriteLine("Emp_Wage:" + Emp_Wage);
            }
            Console.WriteLine("Total_Emp_Wage:" + Total_Emp_Wage);
        }
    }
}
