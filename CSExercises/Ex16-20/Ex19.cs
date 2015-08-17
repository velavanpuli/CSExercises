using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double Calculation;
            Console.WriteLine("Travel Distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double distance1 = Math.Ceiling(distance * 10) / 10;
            if (distance1 < 9)
            {
                Calculation= 2.40 + (distance1 * 100) * 0.04;
            }
            else
            {
                Calculation = 2.40 + (85 * 0.04) + ((distance - 9) * 10) * 0.05;
            }
            Console.WriteLine("Charge:{0:c}", Calculation);
            Console.ReadLine();
            }
        }
    }

