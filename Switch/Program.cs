using System;
namespace Switch;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter value1: ");
        double number1=double.Parse(Console.ReadLine());
        Console.Write("Enter value2: ");
        double number2=double.Parse(Console.ReadLine());
        Console.Write("Enter operation to perform (+,-,/,*,%): ");
        char operation=char.Parse(Console.ReadLine());
        
        switch (operation)
        {
            case '+':
            {
                Console.WriteLine($"{number1} + {number2} = {number1+number2}");
                break;
            }
             case '-':
            {
                Console.WriteLine($"{number1} - {number2} = {number1-number2}");
                break;
            }
             case '*':
            {
                Console.WriteLine($"{number1} * {number2} = {number1*number2}");
                break;
            }
             case '/':
            {
                Console.WriteLine($"{number1} / {number2} = {number1/number2}");
                break;
            }
             case '%':
            {
                Console.WriteLine($"{number1} % {number2} = {number1%number2}");
                break;
            }
        }
    }
}