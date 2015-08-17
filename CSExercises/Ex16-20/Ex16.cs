using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter a Gender");
            String Gender = Console.ReadLine();
            if (Gender == "M")
            {
                Console.WriteLine("Good morning Mr. {0}", name);
            }
            else if (Gender == "F")
            {
                Console.WriteLine("Good morning Mrs. {0}", name);
            }
            else
            {
                Console.WriteLine("Enter a proper name");

            }  
        }
    }
}