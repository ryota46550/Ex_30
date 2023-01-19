using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    class Worker:Person
    {
        public string occupation;

        public string Occupation
        {
            get { return occupation; }
        }
        public Worker(string occ,DateTime bd,string n,float w,float h,float d,float we) : base(bd, n, w, h, d, we)
        {
            occupation = occ;
        }
    }
}
