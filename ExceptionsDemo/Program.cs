using System;

namespace ExceptionsDemo
{
    internal class Program
    {
        static void Main()
        {
            CalcAreaExceptionHandled();
            // Division(100, 0);
            //ReadTextFile();

            // SimpleBankAccount bankAccount = new (100);
            //bankAccount.Withdraw(300);
        }

        public static void CalcArea()
        {
            Console.WriteLine("Please enter a radius in cm");
            double radius = double.Parse(Console.ReadLine() ?? string.Empty);
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area is {Math.Round(area, 2)} cm2");
        }

        public static void CalcAreaDefensive()
        {
            Console.WriteLine("Please enter a radius in cm");
            string input = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(input, out double radius))
            {
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"The area is {Math.Round(area, 2)} cm2");
            }
            else
            {
                Console.WriteLine($"Sorry {input} is not a valid radius");
            }
        }

        public static void CalcAreaExceptionHandled()
        {
            Console.WriteLine("Please enter a radius in cm");
            try
            {                
                double radius = double.Parse(Console.ReadLine() ?? string.Empty);
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"The area is {Math.Round(area, 2)} cm2");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Not able to calculate area, Format Exception: {e}");
            }            
        }

        public static void Division(int num1, int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Exception caught: {e}");
            }
            finally
            {
                Console.WriteLine($"Result is {result}");
            }
        }

        public static void ReadTextFile()
        {
            string fileName = @"/Files/mytext.txt";
            //string fileName = @"mytext.txt";

            try
            {
                string allText = File.ReadAllText(fileName);
                Console.Write(allText);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"Directory not found.");
                Console.WriteLine($"Exception {e}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Couldn't read file for some other reason.");
                Console.WriteLine($"Exception {ex}");
            }
        }
    }
}
