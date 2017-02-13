using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter an hourly pay rate");
                String payRate = Console.ReadLine();
                double pay = Convert.ToDouble(payRate);

                if (pay < 5.65 || pay > 49.99)
                {
                    Console.WriteLine("u a rich bitch");
                }
                else
                {
                    Console.WriteLine("That isn't enough.");
                }
            }
        }
    }
}
