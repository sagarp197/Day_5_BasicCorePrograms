using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOf2
    {
        public static void PrintTableOfPower2()
        {
            int no;
            int remainder;
            Console.WriteLine("Enter a no to check");
            no = Convert.ToInt32(Console.ReadLine());
            if (no == 1)
                Console.Write("It is power of 2.");
            else
            {
                while (no > 1)
                {
                    remainder = no % 2;
                    if (remainder != 0)
                        break;
                    no /= 2;
                }
                if (no == 1)
                    Console.WriteLine("It is a power of 2");
                else
                    Console.WriteLine("It is not a power of 2");
            }
        }
    }
}
