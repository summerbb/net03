using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sy1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20]; 
            int sum1 = 0;//奇数和
            int sum2 = 0;//偶数和
            Console.WriteLine("请依次输入数组元素：");
            for (int i = 0; i < 20; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < 20; j = j + 2)
            {
                sum1 = sum1 + a[j];
                sum2 = sum2 + a[j + 1];
            } 
            Console.WriteLine("奇数之和为:" + sum1 );
            Console.WriteLine("偶数之和为:" + sum2 );
        }

        }
     }
     


