using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    class Insect:Animal
    {
        public string type;
        public string Type
        {
            get { return type; }
        }
        public Insect(string type, DateTime bd, string n, float w, float h, float d, float we):base(bd, n, w, h, d, we)
        {
            this.type = type;
        }
    }
}
