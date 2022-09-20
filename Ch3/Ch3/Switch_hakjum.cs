//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ch3
//{
//    internal class switch_hakjum
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                int s;
//                string g;
//                Console.Write("점수 입력 : ");
//                s = int.Parse(Console.ReadLine());
//                if (s == -999) break;
//                if (s < 0 || s > 100)
//                {
//                    Console.WriteLine("점수범위 초과됨");
//                    Console.WriteLine();
//                    continue;
//                }
//                g = grade(s);
//                Console.WriteLine("학점은 {0}", g);
//                Console.WriteLine();
//            }
//        }

//        private static string grade(int score)
//        {
//            string g;
//            switch (score)
//            {
//                case >= 90:
//                    g = "A";
//                    break;
//                case >= 80:
//                    g = "B";
//                    break;
//                case >= 70:
//                    g = "C";
//                    break;
//                case >= 60:
//                    g = "D";
//                    break;
//                default:
//                    g = "F";
//                    break;
//            }
//            return g;
//        }
//    }
//}
