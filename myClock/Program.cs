using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, k; // code is 456

            Console.WriteLine("Enter 3 digit code \nDigit 1:" );
            i = Convert.ToInt32(Console.ReadLine());

            if (i == 4)
            {
                Console.Write("Code is ["+i+"**] \nDigit 2:");
                j = Convert.ToInt32(Console.ReadLine());
                if (i==4 && j==5)
                {
                    Console.Write("Code is ["+i + j+"*] \nDigit 3:");
                     k = Convert.ToInt32(Console.ReadLine());
                    if (i==4 && j==5 && k == 6)
                    {
                        Console.Write("Code is ["+i + j + k+"] \nUNLOCKED");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("INCORRECT");
                    }
                }
                else
                {
                    Console.Write("INCORRECT");
                }
            }
            else
            {
                Console.Write("INCORRECT");
            }


            
            /* local variable definition 
            int i, j;

            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break; // if factor found, not prime
                if (j > (i / j)) Console.WriteLine("{0} is prime", i);
            }
            Console.ReadLine();*/
        }
    }
}