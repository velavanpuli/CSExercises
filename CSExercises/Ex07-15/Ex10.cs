using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double d = Math.Sqrt(x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            Console.WriteLine("the distance is{0} ", d);   
        }
    }
}
