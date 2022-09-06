using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1
{
    internal class 질문
    {
        public static string ABC(int fix_num, int input_num)
        {
            string result;
            if (fix_num == input_num) result = "정답";
            else if (fix_num > input_num) result = "너무작어";
            else result = "너무 커";
            return result;
        }
    }
}   // 결과를 변수에 저장해두었다가 마지막에 return하는 것이 좋음
