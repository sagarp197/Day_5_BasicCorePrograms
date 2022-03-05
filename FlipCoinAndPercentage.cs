using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoinAndPercentage
    {
        public static void DisplayPercentage()
        {
            Console.WriteLine("Please enter the value for number of flips");
            int Flip = Convert.ToInt32(Console.ReadLine());

            int head = 0;
            int tail = 0;
            int headcount = 0;
            int tailcount = 0;

            double headpercentage;
            double tailpercentage;

            if (Flip>0)
            {

                for (int i = 0; i < Flip; i++)
                {
                    Random random = new Random();
                    int coin = random.Next(2);


                    if (coin == 0)
                    {
                        Console.WriteLine("Head");
                        head = 1;
                        headcount += head;

                    }

                    else if (coin == 1)
                    {
                        Console.WriteLine("tail");
                        tail = 1;
                        tailcount += tail;
                         
                    }
                }
                    headpercentage = (headcount * 100) / Flip;
                    tailpercentage = (tailcount * 100) / Flip;
                    Console.WriteLine("No of Head Percentage" + headpercentage);
                    Console.WriteLine("No of Tail Percentage" + tailpercentage);

                
                
                
            }

        }
    }
}
