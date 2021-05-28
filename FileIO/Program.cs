/*
 * Austin Rogers
 * ITSC-3112
 * File I/O Program
 * Read a file (Numbers.txt) for a collection of numbers
 * Write even numbers to even.txt
 * Write odd numbers to odd.txt
 */
using System;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.IO.StreamReader file =
               new System.IO.StreamReader(@"C:\Users\Austin\source\repos\FileIO\Numbers.txt");
            //Read all numbers from Numbers.txt
            String[] numbers = System.IO.File.ReadAllLines(@"C:\Users\Austin\source\repos\FileIO\Numbers.txt");

            /*
             * Writers for even and odd files
             * Can modify to place files in different directory
             */
            System.IO.StreamWriter odd =
                new System.IO.StreamWriter(@"C:\Users\Austin\source\repos\FileIO\Odd.txt");     
            System.IO.StreamWriter even =
                new System.IO.StreamWriter(@"C:\Users\Austin\source\repos\FileIO\Even.txt");

            int temp = 0;
            /*
             * Check each number and write to the intended file.
             */
            for (int i = 0; i < numbers.Length; i++)
            {
                temp = Int32.Parse(numbers[i]);
                Console.WriteLine(temp);
                if(temp % 2 == 0)   //Even numbers
                {   
                    even.WriteLine(temp);
                    even.Flush();
                }
                else               //Odd numbers
                {
                    odd.WriteLine(numbers[i]);
                    odd.Flush();
                }
                
            }
            file.Close();
            odd.Close();
            even.Close();


        }
    }
}
