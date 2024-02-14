using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool isValid;

            do
            {
                Console.Write("Enter a number below 10: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out num) && num < 10;

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a number below 10.");
                }
            } while (!isValid);

            Console.WriteLine($"Times table for {num}:");

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{i} * {num} = {i * num}");
            }

            Console.ReadKey();

        }
    }
}
