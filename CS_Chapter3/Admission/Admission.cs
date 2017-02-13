using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's Your GPA?");
            double gpaOne = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("What's Your Test Score?");
            double testScoreOne = Convert.ToDouble(Console.ReadLine());

            if (gpaOne >= 3.0 && testScoreOne >= 60 || gpaOne <= 3.0 && testScoreOne >= 80)
            {
                Console.WriteLine("ACCEPT");
            } 
            else
            {
                Console.WriteLine("REJECT");
            }

        }
    }
}
