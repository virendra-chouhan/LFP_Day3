using System;

namespace UC1_Check_Emp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Present = 1;
            
            
            

            Random random = new Random();

            int emp_type = random.Next(0, 2);
            if (emp_type == Is_Present)
            {
                Console.WriteLine("Your_Are_Present");
            }
            else
            {
                Console.WriteLine("You_Are_Absent");
            }
            
        }
    }
}
