using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    public class Calc
    {
        public static int Calc_Year(int year, int gen_code)
        {
            if (gen_code < 3) year += 1900;
            else year += 2000;
            return year;
        }
        public static int Calc_Age(int year, int month, int day, string now)
        {
            int c_year, c_month, c_day, age;
            c_year = int.Parse(now.Substring(0, 4));
            c_month = int.Parse(now.Substring(5, 2));
            c_day = int.Parse(now.Substring(8, 2));
            if (c_month > month) age = c_year - year;
            else if (c_month < month) age = c_year - year -1;
            else if (c_day >= day) age = c_year - year;
            else age = c_year - year - 1;
            return age;
        }
        public static int Calc_KorAge(int year, int c_year)
        {
            int age = c_year - year + 1;
            return age;
        }
        public static string Calc_Gender(int gen_code)
        {
            string gender = (gen_code % 2 == 0) ? "여자" : "남자";
            return gender;
        }
    }
}
