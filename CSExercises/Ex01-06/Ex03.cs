using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a double precision number");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the sqrt of a number {0} ", Math.Sqrt(x)); 
        }
    }
}
