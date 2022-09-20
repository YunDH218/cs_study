//public class 성적입력
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            string id, name;
//            int kor, eng, mat;
//            int tot = 0;
//            double avg = 0;
//            Console.Write("학번 입력 ");
//            id = Console.ReadLine();
//            if (id == "-999") break;
//            Console.Write("이름 입력 ");
//            name = Console.ReadLine();
//            Console.Write("국어 입력 ");
//            kor = int.Parse(Console.ReadLine());
//            while (kor < 0 || kor > 100)
//            {
//                Console.Write("범위 초과됨, 국어점수 다시 입력 ");
//                kor = int.Parse(Console.ReadLine());
//            }
//            Console.Write("영어 입력 ");
//            eng = int.Parse(Console.ReadLine());
//            while (eng < 0 || eng > 100)
//            {
//                Console.Write("범위 초과됨, 영어점수 다시 입력 ");
//                eng = int.Parse(Console.ReadLine());
//            }
//            Console.Write("수학 입력 ");
//            mat = int.Parse(Console.ReadLine());
//            while (mat < 0 || mat > 100)
//            {
//                Console.Write("범위 초과됨, 수학점수 다시 입력 ");
//                mat = int.Parse(Console.ReadLine());
//            }
//            tot = Sungjuk.Total(kor, eng, mat);
//            avg = tot / 3;
//            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6:F2}",
//                id, name, kor, eng, mat, tot, avg);
//        }
//        Console.WriteLine("성적처리 끝");
//    }
//}

//public class Sungjuk
//{
//    public static int Total(int kor, int eng, int mat)
//    {
//        int result = kor + eng + mat;
//        return result;
//    }
//}