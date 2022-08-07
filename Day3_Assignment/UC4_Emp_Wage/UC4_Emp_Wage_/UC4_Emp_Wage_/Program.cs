using System;

namespace UC4_Emp_Wage_
{
    class Program
    {



        static void Main(string[] args)
        {
            Emp_Wage emp = new Emp_Wage();
            
            emp.MultipleCompnies("Dmart", 20, 2, 10);
            emp.MultipleCompnies("Reliance", 20, 4, 10);
        }
    }
}
