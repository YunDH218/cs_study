using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1
{
    internal class 숫자퀴즈
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int fix_num = rand.Next(100);
            int count = 0;
            while (true)
            {
                Console.Write("상대가 생각하고 있는 수를 입력하세요: ");
                int input_num = int.Parse(Console.ReadLine());
                count++;
                string r = 질문.ABC(fix_num, input_num);
                Console.WriteLine(r);
                if (r == "정답")
                {
                    Console.WriteLine("시도횟수 = {0}", count);
                    Console.WriteLine("랜덤 수는 = {0}", fix_num);
                    break;
                }
            }
        }
    }
}
