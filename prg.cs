// This is master file for console app
using System;
class sum
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = a + b;
        Console.WriteLine("Sum of two numbers is: " + c);
    }
}   