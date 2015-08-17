using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Mark");
            int Mark = Convert.ToInt32(Console.ReadLine());
            if (Mark >= 80 && Mark <= 100)
            {
                Console.WriteLine("you scored {0} marks which is grade A", Mark);
            }
            else if (Mark >= 60 && Mark <= 79)
            {
                Console.WriteLine("you scored {0} marks which is grade B", Mark);
            }
            else if (Mark >= 40 && Mark <= 59)
            {
                Console.WriteLine("you scored {0} marks which is grade C", Mark);
            }
            else if (Mark >= 0 && Mark <= 40)
            {
                Console.WriteLine("you scored {0} marks which is grade F", Mark);
            }
            else
            {
                Console.WriteLine("**Error**");
            }  
        }
    }
}