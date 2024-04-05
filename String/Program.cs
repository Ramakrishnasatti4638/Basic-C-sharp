using System;
namespace String;
class Program 
{
    public static void Main(string[] args)
    {   
        Console.Write("Enter Main String: ");
        string input1=Console.ReadLine();
        Console.Write("String to be searched: ");
        string input2=Console.ReadLine();
        // string z="";
        // int sum=0;
        // for(int i=0;i<input1.Length-1;i++)
        // {
        //     int j=i;
        //     z="";
        //     while (z.Length<input2.Length)
        //     {
                
        //         z+=input1[j];
        //         if(z.Length==input2.Length && z.Contains(input2))
        //         {
        //             sum+=1;
        //         }
        //         if (j<input1.Length-1)
        //         {
        //             j+=1;
        //         }
                
                
        //     }
           

        // }
        
        // Console.WriteLine($"String searched count is {sum}");

        string[] temp=input1.Split(input2);

        foreach(string var in temp)
        {
            Console.WriteLine(var);
        }
        Console.WriteLine(temp.Length-1);
        
    }
}