using System;
using System.Xml.Schema;

namespace CSClass3205_2
{
    class Program
    {
        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }

        static void Main(string[] args)
        {
            //24-1. 제네릭
            Wanted<string> wantedString = new Wanted<string>("String");
            Wanted<int> wantedInt = new Wanted<int>(52273);
            Wanted<double> wantedDouble = new Wanted<double>(52.273);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);


            //24-2. 인덱서
            Products p = new Products();
            Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.");
            p[2] = "단무지";
            Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.");


            //24-3. out 키워드
            Console.WriteLine("숫자 입력: ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("입력한 숫자" + output);
            }
            else Console.WriteLine("숫자를 입력해주세요!");
            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;
            Console.WriteLine("현재 좌표: (" + x + ", " + y + ")");
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + ", " + y + ")");


            //24-4. 구조체
            Point point;
            point.X = 10;
            point.y = 10;
            point = new Point(100, 200);
            point = new Point();
            Console.WriteLine(point.X + " / " + point.y);

            //복사: 구조체 vs 클래스
            PointClass pcA = new PointClass(10, 20);
            PointClass pcB = pcA;
            pcB.x = 100;
            pcB.y = 200;
            Console.WriteLine("pcA: " + pcA.x + " / " + pcA.y);
            Console.WriteLine("pcB: " + pcB.x + " / " + pcB.y);

            PointStruct psA = new PointStruct(10, 20);
            PointStruct psB = psA;
            psB.x = 100;
            psB.y = 200;
            Console.WriteLine("psA: " + psA.x + " / " + psA.y);
            Console.WriteLine("psB: " + psB.x + " / " + psB.y);
        }

        class PointClass
        {
            public int x;
            public int y;
            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct PointStruct
        {
            public int x;
            public int y;
            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct Point
        {
            public int X;
            public int y;
            public string testA; // ="test; //초기화 불가능
            public string testB;

            public Point(int x, int y)
            {
                this.X = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화";
            }

            public Point(int x, int y, string s)
            {
                this.X = x;
                this.y = y;
                this.testA = s;
                this.testB = s;
            }
        }
    }
}
