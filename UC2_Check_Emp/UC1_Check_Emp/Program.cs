using System;

namespace UC1_Check_Emp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Fulltime = 1;
            int Emp_Hours;
            int Emp_Hrs_Rate = 25;
            int Emp_Wage = 0;

            Random random = new Random();

            int emp_type = random.Next(0, 2);
            if (emp_type == Is_Fulltime)
            {
                Emp_Hours = 8;
            }
            else
            {
                Emp_Hours = 4;
            }
            Emp_Wage = Emp_Hours * Emp_Hrs_Rate;
            Console.WriteLine("Emp_Wage:" + Emp_Wage);
        }
    }
}
