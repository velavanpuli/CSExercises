using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity of TV, DVD, Mp3 Respectively:");
            int tv = Convert.ToInt32(Console.ReadLine());
            int dvd = Convert.ToInt32(Console.ReadLine());
            int mp3 = Convert.ToInt32(Console.ReadLine());
            double total = (tv * 900) + (dvd * 500) + (mp3 * 700);
            if (total >= 5000 && total <= 10000)
            {
                double dtv = (tv * 900 * 10) / 100;
                double ddvd = (dvd * 500 *10) / 100;
                double tdiscount = total - (dtv + ddvd);
                Console.WriteLine("Total Price After Discount :{0:c}", tdiscount);

            }
            else if(total > 10000)
            {
                double dtv = (tv *900 * 15) / 100;
                double ddvd = (dvd * 500 *15) / 100;
                double tdiscount = total - (dtv + ddvd);
                Console.WriteLine("Total Price After Discount :{0:c}", tdiscount);
            }
            else
            {
                Console.WriteLine("total price:{0:c}", total);
            }
            Console.ReadLine();
        }
    }
}