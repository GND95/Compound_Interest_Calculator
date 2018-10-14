using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Interest_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double interestRate, numberOfYears, total, interestGains;
            double Calculate(double Starting, double IR)
            {
                interestGains = Starting * (IR / 100);
                total = interestGains + Starting;

                return (Math.Round(total, 2));
            }

            try
            {
                Console.WriteLine("What is your starting value?");
                total = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is your interest rate (%) per year?");
                interestRate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("How many years are you keeping this money in here?");
                numberOfYears = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < numberOfYears; i++)
                {
                    Console.WriteLine("Your total for year " + (i + 1) + " is $" + Calculate(total, interestRate) + " and you've gained $" + Math.Round(interestGains, 2) + " in interest this year.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter numbers only. Press enter to restart.");
            }
            Console.ReadLine();
            Console.Clear();
            Main(args);
        }
    }
}
