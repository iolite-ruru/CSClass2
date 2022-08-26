using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSClass3205_2
{
    class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo([AllowNull] Product other)
        {
            //return this.Price - other.Price;
            //return this.Price.CompareTo(other.Price);
            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return this.Name + " : " + this.Price + "원";
        }
    }
}
