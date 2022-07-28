using System;

namespace UC4_Emp_Wage_
{
    class Program
    {
        public const int Is_Fulltime = 1;
        public const int Is_Parttime = 2;

        public const int Emp_Hrs_Rate = 25;
        
        public const int Defoult = 0;
        
        static void Main(string[] args)
        {
            

            Random random = new Random();

            int emp_type = random.Next(0, 3);
            int Emp_Hours;
            int Emp_Wage;
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
            Console.WriteLine("Emp_Type:" + emp_type);
            Console.WriteLine("Emp_Wage:" + Emp_Wage);

        }
    }
}
