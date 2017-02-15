using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class PayRoll
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much are you paid per hour?");
            String perHourOne = Console.ReadLine();
            double hourlyPay = Convert.ToDouble (perHourOne);

            Console.WriteLine("How many hours did you work?");
            String amountOfHours = Console.ReadLine();
            int amountOfHoursWorked = Convert.ToInt32(amountOfHours);

            double grossPay = hourlyPay * amountOfHoursWorked;
            double withholdingTax = grossPay * 0.12, netPay = 0;

            if (grossPay <= 300.00)
            {
                withholdingTax = grossPay * 0.10;
            }

            netPay = grossPay - withholdingTax;

            Console.WriteLine("Your net pay is $" + netPay);


        }
    }
}
