using System;

namespace CSClass3205_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //24-1. 제네릭
            Wanted<string> wantedString = new Wanted<string>("String");
            Wanted<int> wantedInt = new Wanted<int>(52273);
            Wanted<double> wantedDouble = new Wanted<double>(52.273);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);

            //24-2.인덱서
            Products p = new Products();
            Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.");
            p[2] = "단무지";
            Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.");

        }
    }
}
