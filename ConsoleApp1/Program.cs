using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;
            //foreach(int i in number)
            //{
            //    sum += i;
            // }
            //Console.WriteLine("ket qua la " + sum);
            //Console.ReadKey();

            int n;
            Console.WriteLine("nhap phan tu: ");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap phan tu thu " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(numbers);
            Array.Reverse(numbers);  
            Console.WriteLine("mang sau khi sap xep: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
