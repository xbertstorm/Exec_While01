using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_While01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1+ 2 + 3 + 4 + .... + N <105   請問 N 是多少?");
            Console.Write("Ans：");
            Q01();

            Console.WriteLine();
            Console.WriteLine("使用 while , 在畫面顯示所有可以整除 300 的整數");
            Console.Write("Ans：");
            Q02();

            Console.Read();
        }
        private static void Q01()
        {
            //1+ 2 + 3 + 4 + .... + N <105   請問 N 是多少?

            int i = 1;
            int result = 0;
            while (true)
            {
                result += i;
                if (result > 100)
                    break;
                i++;
            }

            Console.WriteLine(i);
        }
        private static void Q02()
        {
            //使用 while , 在畫面顯示所有可以整除 300 的整數  例如: 1, 2, 3, 4, 5, 6, 10, ...., 300

            int i = 1;
            int count = 0;

            while (true)
            {
                if (300 % i == 0)
                    count++;
                if (i > 300)
                    break;
                i++;
            }

            int[] Storage = new int[count];
            int j = 1;
            int k = 0;
            while (true)
            {
                if (300 % j == 0)
                {
                    Storage[k] = j;
                    k++;
                }
                if (j > 300)
                    break;
                j++;
            }

            for (int c = 0; c < count; c++)
            {
                if (c < count - 1)
                    Console.Write(Storage[c] + ",");
                else
                    Console.Write(Storage[c]);
            }
        }
	}
}
