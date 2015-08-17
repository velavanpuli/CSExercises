using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name");
            String name = Console.ReadLine();
            Console.WriteLine("Gender");
            String Gender = Console.ReadLine();
            Console.WriteLine("Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Gender == "M" && Age >= 40)
            {
                Console.WriteLine("Good Morning uncle {0}", name);
            }
            else if (Gender == "M" && Age < 40)
            {
                Console.WriteLine("Good Morning Mr {0}", name);
            }
            else if (Gender == "F" && Age >= 40)
            {
                Console.WriteLine("Good Morning Aunty {0}", name);
            }
            else if (Gender == "F" && Age < 40)
            {
                Console.WriteLine("Good Morning Ms {0}", name);
            }
            else
            {
                Console.WriteLine("Enter a proper name");
            }
  
        }
    }
}