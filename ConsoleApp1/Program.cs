using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of code to run:");
        int N = int.Parse(Console.ReadLine());

        if (N == 1)
        {
            Console.WriteLine("Jeel Kukadiya");
            Console.WriteLine("202, mayur, dwarika lowrise near madhapar circle, 150ft ring road, rajkot, gujarat, india");
            Console.WriteLine("9712729888");
            Console.WriteLine("Rajkot");
        }
        else if (N == 2)
        {
            int a, b;
            Console.WriteLine("Enter 1st number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + $"{a} {b}");
        }
        else if (N == 3)
        {
            string name, country;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();

            Console.WriteLine("Enter country");
            country = Console.ReadLine();

            Console.WriteLine($"Hello {name} from country {country}");

        }
        else if (N == 4)
        {
            int l, w, a;
            Console.WriteLine("Enter Length: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            w = Convert.ToInt32(Console.ReadLine());
            Console.Write(l * w + "sq. ft");
        }
        else if (N == 5) {
            int l, len, wid, r;
            Console.WriteLine("Enter Length of square: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(l * l);

            Console.WriteLine("Enter Length of rec.: ");
            len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width of rev.: ");
            wid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(len * wid);
            
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(3.14 * r * r);
        }
        else if (N == 6)
        {
            int c, f, F, C;
            Console.WriteLine("Enter Celsius: ");
            c = Convert.ToInt32(Console.ReadLine());
            F = c * (9 / 5) + 32;
            Console.WriteLine("Fahrenheit: " + F);
            Console.WriteLine("Enter Fahrenheit: ");
            f = Convert.ToInt32(Console.ReadLine());
            C = (f - 32) * (5 / 9);
            Console.WriteLine("Celsius: " + C);
        }
        else if (N == 7)
        {
            int P, R, T;
            float SI;
            Console.WriteLine("Enter principal amount: ");
            P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate: ");
            R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter time: ");
            T = Convert.ToInt32(Console.ReadLine());
            SI = (P * R * T) / 100;
            Console.WriteLine("Simple Intrest: " + SI);
        }
        else if (N == 8)
        {
            int number, num1, num2;
            Console.Write("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation out of: + - x /");
            char a = (char)Console.Read();
            double ans;
            switch (a)
            {
                case '+': 
                    ans=num1 + num2;
                    Console.WriteLine(ans);
                    break;
                case '-':
                    ans = num1 - num2;
                    Console.WriteLine(ans);
                    break;
                case 'x':
                    ans = num1 * num2;
                    Console.WriteLine(ans);
                    break;
                case '/':
                    ans = num1 / num2;
                    Console.WriteLine(ans);
                    break;
            }
        //    Console.Write("Enter 1 for +, 2 for *,3 for /, 4 for - : ");
        //    number = Convert.ToInt32(Console.ReadLine());
        //    if (number == 1)
        //    {
        //        Console.Write("Addition: " + (num1 + num2));
        //    }
        //    else if (number == 2)
        //    {
        //        Console.Write("Addition: " + (num1 * num2));
        //    }
        //    else if (number == 3)
        //    {
        //        if (num2 == 0)
        //        {
        //            Console.WriteLine("Invalid 2nd number");
        //        }
        //        else
        //        {
        //            Console.Write("Addition: " + (num1 / num2));
        //        }
        //    }
        //    else if (number == 4)
        //    {
        //        Console.Write("Subtraction: " + (num1 - num2));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Enter a valid number ");
        //    }
        }
        else if (N == 9)
        {
            int a, b;
            Console.Write("Enter 1st number before swapping: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number before swapping: ");
            b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("1st number after swap: " + a);
            Console.WriteLine("2nd number after swap: " + b);
        }
        else if (N == 10)
        {
            int number1, number2, number3, max;
            Console.Write("Enter 1st number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number : ");
            number3 = Convert.ToInt32(Console.ReadLine());
            max = (number1 > number2 && number1 > number3) ? number1 : (number2 > number3 ? number2 : number3);
            Console.WriteLine("Max from 3 number is: " + max);
        }
    }
}