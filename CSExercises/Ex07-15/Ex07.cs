using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a salary");
            double d = Convert.ToDouble(Console.ReadLine());
            double Ha = 0.1 * d;
            double Ta = 0.03 * d;
            double TotalSalary = d + Ha + Ta;
            Console.WriteLine("Total Salary is {0:$.00}", TotalSalary);  
        }
    }
}
