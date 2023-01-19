using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    class Refrigerator:Thing
    {
        public float price;

        public float Price
        {
            get { return price; }
        }
        public Refrigerator(float price, string n, float w, float h, float d, float we) : base(n, w, h, d, we)
        {
            this.price = price;
        }
    }
}
