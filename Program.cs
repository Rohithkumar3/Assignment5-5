using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your exam score as a percentage: ");
            double examScore = Convert.ToDouble(Console.ReadLine());

            if (examScore >= 90)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (examScore >= 80)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (examScore >= 70)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (examScore >= 60)
            {
                Console.WriteLine("Your grade is D");
            }
            else
            {
                Console.WriteLine("Your grade is F");
            }
            Console.ReadKey();
        }
    }
}
