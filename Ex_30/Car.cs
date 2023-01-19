using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    class Car:Thing
    {
        public float speed;
        public float Speed
        {
            get { return speed; }
        }
        public Car(float s,string n,float w,float h,float d,float we) : base(n, w, h, d, we)
        {
            this.speed = s;
        }
    }
}
