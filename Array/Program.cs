using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, Avg = 0;
            int[] Populate = new int[5];
            for(int i = 1;i<=5;i++)
            {
                Console.WriteLine($"Enter the value {i} to find Average & Sum");
                Console.ReadLine();
            }
            Console.WriteLine("Average of the numbers is:");
           for(int i=0;i<=5;i++)
            {
                
                sum += i;
                Avg = sum / 5;
            }
            Console.WriteLine("Sum of the digits:" + sum);
            Console.WriteLine("Average of the digits:" + Avg);
            Console.ReadKey();
        }
    }
}
