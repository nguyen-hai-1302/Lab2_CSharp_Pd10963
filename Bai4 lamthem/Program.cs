using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_lamthem
{
    internal class Program
    {
        public static Boolean IsPrime(int number)
        {
            if (number < 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;
            int sum1 = 0;            
            List<int> numberList =  new List<int>();
            numberList.Add(10);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(40);
            numberList.Add(5);
            //YC1
            Console.Write("Danh sach cac so nguyen: ");
            foreach(int number in numberList)
            {
                Console.Write(" " + number);
            }
            Console.WriteLine();
            //YC2
            foreach (int number in numberList)
            {                
                sum += number;
            }
            Console.WriteLine("Tong cac so nguyen: " + sum);
            //YC3
            foreach (int number in numberList)
            {
                if (IsPrime(number))
                {
                    sum1 += number;
                }
            }
            Console.WriteLine("Tong cac so nguyen to: " + sum1);
            //YC4
            for (int i = 0; i < numberList.Count; i +=2)
            {
                if (numberList[i] % 2 == 0)
                {
                     sum2+= numberList[i];
                }
            }
            Console.WriteLine("Tong cac so chan vi tri le: " + sum2);
            Console.Read();
        }       
    }
}
