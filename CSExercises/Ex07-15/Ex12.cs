using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("the side a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the side b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the side c");
            int c = Convert.ToInt32(Console.ReadLine());
            double s = (a + b + c) / 2;
            double AREA = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("The AREA OF TRIANGLE {0}", AREA);
        }
    }
}
