using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Double precision number ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the sqrt of the number is {0:#.000}", Math.Sqrt(d));  
        }
    }
}
