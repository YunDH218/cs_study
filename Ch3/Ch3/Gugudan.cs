using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    class Gugudan
    {
        static void Main(string[] args)
        {
            /* 1 단계 */
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.Write("{0}*{1}={2}\t", 2, i, 2 * i);
            //}
            /* 2 단계 */
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("{0}*{1}={2}", 2, i, 2 * i);
            //}
            /* 3 단계 */
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 2; j < 10; j++)
            //    {
            //        Console.Write("{0}*{1}={2:D2}\t", j, i, i * j);
            //    }
            //    Console.WriteLine();
            //}
            /* 4 단계 */
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < i + 1; j++)
            //    {
            //        Console.Write("{0}*{1}={2:D2}\t", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}
            /* 5 단계 */
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1 + i * 3; k < 4 + i * 3; k++)
                    {
                        Console.Write("{0}*{1}={2:D2}\t", k, j, j * k);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
