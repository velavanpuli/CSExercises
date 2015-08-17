using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            int i, num, rem;
            int sum = 0;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            i = num;
            while (i != 0)
            {
                rem = i % 10;
                sum = sum + (rem * rem * rem);
                i = i / 10;

            }
            if (sum == num)
            {
                Console.WriteLine("Entered number is a armstrong number");
            }
            else
            {
                Console.WriteLine("Entered number is not a armstrong number");
            }
        }
    }
}
