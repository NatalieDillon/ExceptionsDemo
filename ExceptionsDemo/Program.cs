using System;

namespace ExceptionsDemo
{
    internal class Program
    {
        static void Main()
        {
            // Division(100, 0);
            //ReadTextFile();

            SimpleBankAccount bankAccount = new (100);
            bankAccount.Withdraw(300);
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
