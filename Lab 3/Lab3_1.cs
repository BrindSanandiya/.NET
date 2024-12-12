using System;

namespace Lab3
{
    class Lab3_1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}