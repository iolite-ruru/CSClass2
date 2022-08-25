﻿using System;

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

/*
            // 24-3. out 키워드
            Console.Write("숫자 입력: ");
            //int output; //인라인 선언을 하면 이 문장 굳이 필요 Xx
            bool result = int.TryParse(Console.ReadLine(), out int output); //인라인 선언

            if (result)
            {
                Console.WriteLine("입력한 숫자: " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요!");
            }*/

            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;
            Console.WriteLine("현재 좌표: (" + x + ", " + y + ")");
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + ", " + y + ")");
        }

        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
    }
}
