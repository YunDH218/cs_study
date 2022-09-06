//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ch1
//{
//    internal class Quiz
//    {
//        static void Main(string[] args)
//        {
//            Random rand = new Random();
//            int answer = rand.Next(1, 100);
//            int i = 0;
//            int count = 0;
//            while (true)
//            {
//                Console.Write("1~100 범위의 수를 입력하세요 : ");
//                i = int.Parse(Console.ReadLine());
//                string result = Question(answer, i);
//                Console.WriteLine(result);
//                count++;
//                if (result == "정답입니다!")
//                {
//                    Console.WriteLine("시도횟수 : {0}", count);
//                    Console.WriteLine("정답 : {0}", answer);
//                    break;
//                }
//            }

//        }

//        static string Question(int answer, int i)
//        {
//            if (i < answer) { return "작습니다."; }
//            else if (i > answer) { return "큽니다."; }
//            else { return "정답입니다!"; }
//        }
//    }
//}
