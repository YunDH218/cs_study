using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    internal class Jumin
    {
        static void Main(string[] args)
        {
            // 변수 선언
            string id, gender;
            int year, month, day, gen_code, age, kor_age;
            string now = Convert.ToString(DateTime.Now);
            int c_year = int.Parse(now.Substring(0, 4));

            // 입력 및 값 할당
            Console.Write("주민번호 13자리를 입력하세요 : ");
            id = Console.ReadLine();
            year = int.Parse(id.Substring(0, 2));
            month = int.Parse(id.Substring(2, 2));
            day = int.Parse(id.Substring(4, 2));
            gen_code = int.Parse(id.Substring(6, 1));

            // 메소드 호출
            year = Calc.Calc_Year(year, gen_code);
            kor_age = Calc.Calc_KorAge(year, c_year);
            age = Calc.Calc_Age(year, month, day, now);
            gender = Calc.Calc_Gender(gen_code);

            // 출력
            Console.WriteLine("년도는 : {0}", year);
            Console.WriteLine("월은 : {0}", month);
            Console.WriteLine("일은 : {0}", day);
            Console.WriteLine("올해 나이는 : {0}", kor_age);
            Console.WriteLine("올해 만나이는 : {0}", age);
            Console.WriteLine("성별은 : {0}", gender);
            Console.WriteLine();
        }

        
    }
}
