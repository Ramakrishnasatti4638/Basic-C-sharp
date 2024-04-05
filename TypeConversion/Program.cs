using System;
using System.Runtime.Intrinsics.Arm;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        // Console.Write("Enter your name: ");
        // string name=Console.ReadLine();
        // Console.Write("Enter age: ");
        // int age=int.Parse(Console.ReadLine());
        // Console.Write("Enter mark of subject1: ");
        // double marks1=double.Parse(Console.ReadLine());
        // Console.Write("Enter mark of subject2: ");
        // double marks2=double.Parse(Console.ReadLine());
        // Console.Write("Enter mark of subject3: ");
        // double marks3=double.Parse(Console.ReadLine());
        // Console.Write("Enter Grade: ");
        // char grade=char.Parse(Console.ReadLine());
        // Console.Write("Enter mobile number: ");
        // long mobileNumber=long.Parse(Console.ReadLine());
        // Console.Write("Enter Mail id: ");
        // string mailId=Console.ReadLine();

        // double total=marks1+marks2+marks3;
        // double average=total/3;
        
        // Console.WriteLine("Trainee Details Are:");
        // Console.WriteLine($"Name: {name}");
        // Console.WriteLine($"Age: {age}");
        // Console.WriteLine($"Mobile: {mobileNumber}");
        // Console.WriteLine($"Marks1: {marks1}");
        // Console.WriteLine($"Marks2: {marks2}");
        // Console.WriteLine($"Marks3: {marks3}");
        // Console.WriteLine($"Total: {total}");
        // Console.WriteLine($"Average: {average:0.00}");
        // Console.WriteLine($"Grade: {grade}");
        // Console.WriteLine($"Mail id: {mailId}");

                int number=int.Parse(Console.ReadLine());
                int count=CountOfArmStrong(number);
                int[] array=new int[count];
                int num=0;
                int index=0;
                do
                {
                    if(IsArmStrong(num))
                    {
                        array[index]=num;
                        index++;
                    }
                    num++;
                }while(num<=number && index<count);
    }
    public static int CountOfArmStrong(int number)
            {
                int count=0;
                for (int i=0;i<=number;i++)
                {
                    if(IsArmStrong(i))
                    {
                        count++;
                    }
                }
                return count;
            }

            public static bool IsArmStrong(int number)
            {
                int number1=number;
                int length=number.ToString().Length;
                int remainder,res=0;
                while(number!=0)
                {
                    remainder=number%10;
                    res+=(remainder*length);
                    number=number/10;
                }
                return res==number1;
            }
}