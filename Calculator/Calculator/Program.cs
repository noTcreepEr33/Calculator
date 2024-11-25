using System;
using System.Threading;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########################");
            Console.WriteLine("Welcome to Calculator!");
            Console.WriteLine("########################");
            int i;
            for (i = 1; i <= 1; i++)
            {
                double num1;
                double num2;
                double result;
                Console.WriteLine("Please enter your first number : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your second number : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select an operation : ");
                Console.WriteLine("a - Add s - subtract m - multiply d - divide");
                string? answer = Console.ReadLine();
                if (answer == "a")
                {
                    result = num1 + num2;
                    Console.WriteLine("The "+ num1 + "+" + num2 + " is:" + result);
                }
                else if (answer == "s")
                {
                    result = num1 - num2;
                    Console.WriteLine("The "+ num1 + "-" + num2 + " is:" + result);
                }
                else if (answer == "m")
                {
                    result = num1 * num2;
                    Console.WriteLine("The "+ num1 + "*" + num2 + " is:" + result);
                }
                else if (answer == "d")
                {
                    result = num1 / num2;
                    Console.WriteLine("The "+ num1 + "/" + num2 + " is:" + result);
                }
                else
                {
                    Console.WriteLine("Please enter a valid operation");
                }
                i = i - 1;
            }
        }
    }
}