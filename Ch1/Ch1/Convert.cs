//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ch1
//{
//    internal class Convert
//    {
//        static void Main(string[] args)
//        {
//            // 숫자 - 캐스팅 연산자 사용
//            double a = 3.5;
//            Console.WriteLine((int)a); // 실수를 정수로 형변환

//            // 문자열 - Convert 클래스의 메소드 사용
//            int t1 = 123;
//            Console.WriteLine(t1.ToString());
//            // Console.WriteLine(Convert.ToString(t1));
//            string t2 = "123";
//            // Console.WriteLine(Convert.ToInt32(t2));
//            Console.WriteLine(int.Parse(t2));

//            // 두 변수에 값이 있을 때 형 변환하여 더한 후 정수 변수 add에 저장 후 10진수로 출력하는 소스를 완성하시오.
//            string s = "123";
//            float f = 321;
//            int add1 = int.Parse(s) + (int)f;   // 정수로 변환 후 덧셈
//            int add2 = int.Parse(f.ToString() + t2);    // 문자열로 변환 후 연결
//            Console.WriteLine(add1);
//            Console.WriteLine(add2);
//        }
//    }
//}
