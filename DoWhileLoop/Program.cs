using System;
namespace DoWhileLoop;
class Program 
{
    public static void Main(string[] args)
    {   
        string option=string.Empty;
        
        do
        {
            Console.Write("Enter a number: ");
            int number=int.Parse(Console.ReadLine());
            if (number%2==0)
            {
                Console.WriteLine($"{number} is a even number");
            }
            else
            {
                Console.WriteLine($"{number} is a odd number");
            }
            Console.Write("Do you want to repeat the process with other number (Yes/No): ");
            option=Console.ReadLine();
            if (option=="Yes" || option=="No")
            {
                continue;
            }
            if (option!="Yes" || option!="No")
            {
                Console.WriteLine("Invalid input, Reneter right value (Yes/No): ");
                option=Console.ReadLine();
            }
            
            
        }while (option=="Yes");
        

    }
}