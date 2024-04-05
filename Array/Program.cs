using System;
namespace Array;
class Program 
{
    public static void Main(string[] args)
    {
        // string[] names=new string[5]{"ramakrishna","sanjay","syam","gowtham","anantha"};
        // for (int i=0;i<names.Length;i++)
        // {
        //     Console.WriteLine(names[i]);
        // }

        // bool nameFound=false;
        // Console.Write("Enter any name: ");
        // string name=Console.ReadLine();
        // for(int i=0;i<names.Length;i++)
        // {
        //     if (name.Equals(names[i]))
        //     {
        //         Console.WriteLine($"The name {name} is present in the array at index {i}");
        //         nameFound=true;
               
        //     }
        // }
        // if (!nameFound)
        // {
        //    Console.WriteLine($"The name {name} is not present in the array ");
        // }


        // bool nameFound1=false;
        // foreach(string var in names)
        // {
        //     if (var.Equals(name))
        //     {
        //         Console.WriteLine($"The name {name} is present in the array");
        //         nameFound1=true;
                
        //     }
        // }
        // if (!nameFound1)
        // {
        //    Console.WriteLine($"The name {name} is not present in the array ");
        // }

                double price=double.Parse(Console.ReadLine());
                float taxRate=18/100;
                double total=price+(price*taxRate);
                Console.WriteLine(total);
    }
}