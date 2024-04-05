using System;
namespace DateTimes;
class Program 
{
    public static void Main(string[] args)
    {
        // DateTime date=new DateTime(2021,8,10,10,40,32);
        // Console.WriteLine($"The year is: {date.Year}");
        // Console.WriteLine($"The month is: {date.Month}");
        // Console.WriteLine($"The day is: {date.Day}");
        // Console.WriteLine($"The hour is: {date.Hour}");
        // Console.WriteLine($"The Minutes are: {date.Minute}");
        // Console.WriteLine($"The seconds are: {date.Second}");
        // Console.WriteLine(date);

        // string date1=date.ToString();
        // Console.WriteLine(date1);
        // string[] array=date1.Split('/',' ',':');
        // for(int i=array.Length-1;i>0;i--)
        // {
        //     Console.Write(array[i]+" ");
        // }

        // Console.WriteLine();
        // DateTime newDate;
        // Console.WriteLine("Enter date in (yyyy/MM/dd hh:mm:ss tt) format: ");
        // bool temp=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out newDate);
        // Console.WriteLine(newDate.ToString("yyyy"));
        // Console.WriteLine(newDate.ToString("MM"));
        // Console.WriteLine(newDate.ToString("dd"));

                // DateTime date;
                // bool temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out date);
                // //TimeSpan span=date.AddDays(40);
                // DateTime newDate=date.AddDays(40);
                // Console.WriteLine($"Date:{newDate}");
                // Console.WriteLine($"Day:{newDate.DayOfWeek}");

                // string name=Console.ReadLine();
                
                // for(int i=0;i<name.Length-1;i++)
                // {
                //     for(int j=i+1;j<name.Length;j++)
                //     {
                //         if(name[i]==name[j])
                //         {
                //             name=name.Remove(j,1);
                //         }
                //     }
                // }
                
                // foreach(char c in name)
                // {
                //     Console.Write(c);
                // }



                // int m=int.Parse(Console.ReadLine());
                // int n=int.Parse(Console.ReadLine());
                // int[,] matrix=new int[m,n];
                // for(int i=0;i<m;i++)
                // {
                //     for(int j=0;j<n;j++)
                //     {
                //         matrix[i,j]=int.Parse(Console.ReadLine());
                //     }
                // }

                // int[,] matrix1=new int[n,m];
                // for(int i=0;i<n;i++)
                // {
                //     for(int j=0;j<m;j++)
                //     {
                //         matrix1[i,j]=int.Parse(Console.ReadLine());
                //     }
                // }

                // // int[,] newMatrix=Mutiplication(matrix,matrix1,n);

                // int[,] newMatrix=new int[m,m];
                // for(int i=0;i<n;i++)
                // {
                //     for(int j=0;j<n;j++)
                //     {
                //         for(int k=0;k<n;k++)
                //         {
                //             newMatrix[i,j]+=matrix[i,k]*matrix1[k,j];
                //         }
                //     }
                // }

                // for(int i=0;i<n;i++)
                // {
                //     for (int j=0;j<n;j++)
                //     {
                //         Console.Write(newMatrix[i,j]+" ");
                //     }
                //     Console.WriteLine();
                // }
                

                // DateTime date;
                // bool temp=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out date);
                // DateTime today=DateTime.Now;
                // TimeSpan span=DateTime.Now-date;
                // int age=Math.Abs(int.Parse(date.ToString("yyyy"))-int.Parse(today.ToString("yyyy")));
                
                // string day=date.ToString("dddd");
                // int days=span.Days;
                // int hours=span.Hours;
                // int minutes=span.Minutes;
                // int seconds=span.Seconds;
                // int milliSeconds=span.Microseconds;
                // Console.WriteLine($"Your age is : {age} and Day you are born was {day}");
                // System.Console.WriteLine($"Age in days, hours, minutes, seconds and milliseconds is: days {days}, Hours: {hours}, Minutess:  {minutes}, Seconds:{seconds}, milliseconds:{milliSeconds}");




                string input1=Console.ReadLine();
                string input2=Console.ReadLine();
                if(input1.Length!=input2.Length)
                {
                    System.Console.WriteLine("Not an Anagram");
                }
                else
                {
                    bool found=true;
                    for(int i=0;i<input1.Length;i++)
                    {
                        bool isFound=false;
                        for(int j=0;j<input2.Length;j++)
                        {
                            if(input1[i]==input2[j])
                            {
                                isFound=true;

                            }
                        }
                        if(isFound==false)
                        {
                            Console.WriteLine("Not anagram");
                            found=true;
                            break;
                        }
                    }
                    if(!found)
                    {
                        System.Console.WriteLine("anagram");
                    }
                }



                // int number1=int.Parse(Console.ReadLine());
                // int number2=int.Parse(Console.ReadLine());
                // double res=1;
                // int i=1;
                // while(number2-1>0)
                // {
                //     res+=(Math.Pow(number1,i)/Factorail(i));
                //     number2-=1;
                //     i+=1;
                // }
                // Console.WriteLine(Math.Round(res,2));
    }

    // public static int Factorail(int number)
    //         {
    //             int res=1;
    //             for(int i=1;i<=number;i++)
    //             {
    //                 res*=i;
    //             }
    //             return res;
    //         }
    

    
}