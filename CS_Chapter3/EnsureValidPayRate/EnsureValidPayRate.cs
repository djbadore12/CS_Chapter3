using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
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
                    Console.WriteLine("Enter an hourly pay rate");
                    string payRateTwo = Console.ReadLine();
                    double payTwo = Convert.ToDouble(payRateTwo);

                    if (payTwo > 5.65 || payTwo > 49.99)
                    {
                        Console.WriteLine("your pay rate is $" + payTwo);
                        double weeklyRateTwo = payTwo * 40;
                        Console.WriteLine("your weekly rate will be $" + weeklyRateTwo);
                    }
                    else
                    {
                        Console.WriteLine("not a valid amount");
                    }

                }
                else
                {
                    Console.WriteLine("That isn't enough.");
                }
            }
        }
    }
}
