﻿using System;
using System.Runtime.Intrinsics.Arm;
namespace IfCondition;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your marks: ");
        double marks=double.Parse(Console.ReadLine());
        Console.WriteLine($"Marks Entered are: {marks} ");
        Console.Write("Your grade is: ");
        if (marks > 80 && marks<=100)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks>=61 && marks<=80)
        {
            Console.WriteLine("Garde B");
        }
        else if (marks>=36 && marks<=60)
        {
            Console.WriteLine("Garde C");
        }
        else if (marks<36 && marks>=0)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}