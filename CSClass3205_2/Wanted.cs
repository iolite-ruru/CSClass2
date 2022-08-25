using System;
using System.Collections.Generic;
using System.Text;

namespace CSClass3205_2
{
    class Wanted<T>
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }
}
