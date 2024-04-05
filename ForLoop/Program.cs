using System;
using System.Runtime.Intrinsics.Arm;
namespace ForLoop;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number1 : ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter number2 : ");
        int number2=int.Parse(Console.ReadLine());
        int sum=0;
        for (int i=number1;i<=number2;i++)
        {
            sum+=(i*i);
        }
        Console.WriteLine($"The sum of square of numbers between {number1} and {number2} is : {sum}");
    }
}