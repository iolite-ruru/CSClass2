using System.Collections.Generic;
using System;

namespace CSClass3205_2
{
    class Products
    {
        private List<string> items = new List<string>() { "짜장면", "짬뽕", "탕수육" };
        public string this[int i]
        {
            get { return items[i]; }
            set
            {
                items[i] = value;
                Console.WriteLine(i + "번째 상품을 " + value + "로 설정");
            }
        }
    }
}