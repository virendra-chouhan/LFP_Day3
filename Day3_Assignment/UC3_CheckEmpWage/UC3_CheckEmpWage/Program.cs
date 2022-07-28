using System;

namespace UC3_CheckEmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Fulltime = 1;
            int Is_Parttime = 2;
            int Emp_Hours;
            int Emp_Hrs_Rate = 25;
            int Emp_Wage = 0;

            Random random = new Random();

            int emp_type = random.Next(0, 3);
            if (emp_type == Is_Fulltime)
            {
                Emp_Hours = 8;
            }

            else if (emp_type == Is_Parttime)
            {
                Emp_Hours = 4;
            }
            else
            {
                Emp_Hours = 0;
            }
            Emp_Wage = Emp_Hours * Emp_Hrs_Rate;
            Console.WriteLine("Emp_Type:" + emp_type);
            Console.WriteLine("Emp_Wage:" + Emp_Wage);
        }
    }
}
