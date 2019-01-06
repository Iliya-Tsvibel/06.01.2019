using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            int primeNumber = Convert.ToInt32(Console.ReadLine());

            bool IsPrime = CheckIfPrime(primeNumber);

            Console.WriteLine($"{IsPrime} is prime? {IsPrime}");

            Console.WriteLine($"{IsPrime} is prime? { CheckIfPrime(primeNumber) }");

            if (CheckIfPrime(primeNumber))
            {
                Console.WriteLine($"{primeNumber} is Prime!");
            }
            else
            {
                Console.WriteLine($"{primeNumber} is NOT Prime!");
            }
        }

        private static bool CheckIfPrime(int primeNumber)
        {
            
            int m = 2;
                while (primeNumber % m != 0)
                {
                    m++;
                }

                if (m < primeNumber)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

      
    }
    
}
