using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an hourly pay rate");
            String payRate = Console.ReadLine();
            double pay = Convert.ToDouble(payRate);

            if (pay <= 5.65)
            {
                Console.WriteLine("Error, u poor");
            }
            else 
            {
                Console.WriteLine("you a rich bitch");
            }
        }
    }
}
