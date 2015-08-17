using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a double precision number ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square of a double precision number is {0} ", d * d);
        }
    }
}
