using System;
using System.ComponentModel;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
namespace MethodPractice;
class Program 
{
    public static void Main(string[] args)
    {
        string option="";
        do
        {   
            Console.Write("Enter number1: ");
            double number1=double.Parse(Console.ReadLine());
            Console.Write("Enter number1: ");
            double number2=double.Parse(Console.ReadLine());
            
            
            Console.Write("Enter operation you want to perform(+,-,/,*): ");
            char operation=char.Parse(Console.ReadLine());
            switch(operation)
            {
                case '+':
                {
                    Console.WriteLine(Add(number1,number2));
                    break;
                }
                case '-':
                {
                    Console.WriteLine(Subtraction(number1,number2));
                    break;
                }
                case '*':
                {
                    Console.WriteLine(Multiplication(number1,number2));
                    break;
                }
                case '/':
                {
                    Console.WriteLine(Division(number1,number2));
                    break;
                }
                default:
                {
                    Console.WriteLine("Try again!");
                    break;
                }
            }
            System.Console.Write("Do you want to continue(Yes/No): ");
            string option1=Console.ReadLine();
            option=option1;
            
        }while (option=="Yes");
    }

    static double Add(double num1,double num2)
    {
        return num1+num2;
    } 

    static double Subtraction(double number1,double number2)
    {
        return number1-number2;
    }

    static double Multiplication(double number1,double number2)
    {
        return  number1*number2;
    }

    static double Division(double number1,double number2)
    {
        return number1/number2;
    }


    
}