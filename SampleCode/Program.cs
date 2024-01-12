using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Odd or Even
            //int N = int.Parse(Console.ReadLine());
            //if (N % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}


            ////Last Digit
            //int Num = int.Parse(Console.ReadLine());
            //Console.WriteLine(Num%10);


            ////Count the digit
            //int num = int.Parse(Console.ReadLine());
            //int Count = 0;
            //bool value = true;
            //while (value)
            //{
            //    if (num > 0)
            //    {
            //        int temp = num % 10;
            //        Count++;
            //        num = num / 10;
            //    }
            //    else
            //    {
            //        value = false;
            //    }

            //}
            //Console.WriteLine("Count :" + Count);

            // Reverse the number
            int Number = int.Parse(Console.ReadLine());
    
            while (Number!=0)
            {
                if (Number > 0)
                {
                    int temp = Number % 10;
                    Console.Write(temp);
                    Number = Number / 10;
                }
                else
                {
                    break;
                }

            }
        }
    }
}
