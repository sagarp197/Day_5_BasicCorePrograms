using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public static void DisplayNthHarmonicNumber()
        {
            int n;
            float i;

            Console.WriteLine("1 + 1 / 2 + 1 / 3 +......+1 / n \n");
            Console.WriteLine("Enter the value of n \n");
            n = Convert.ToInt32(Console.ReadLine());
            Double sum = 0;
            for (i = 1; i <= n; i++)
            {

                
                if (i == 1)
                    Console.WriteLine("\n 1 +");
                else if (i == n)
                    Console.WriteLine(" (1 / %lf)", i);
                else
                    Console.WriteLine(" (1 / %lf) + ", i);
                sum = sum + (1 / i);
            }
            Console.WriteLine("the Given Number Harmonic Value sum  = "+ sum);
        }
    }
}
