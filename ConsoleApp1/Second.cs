using System;
using System.Security.Cryptography.X509Certificates;

class Second
{
    static void Sec(String[] args)
    {
        int a, b;
        Console.WriteLine("Enter 1st number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 2nd number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a + b);
    }
}