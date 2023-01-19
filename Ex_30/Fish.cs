using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    class Fish:Animal
    {
        public string from;
        public string From
        {
            get { return from; }
        }
        public Fish(string f,DateTime bd, string n, float w, float h, float d, float we) : base(bd,n, w, h, d, we)
        {
            this.from = f;
        }
    }
}
