using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    /// <summary>
    /// 生き物
    /// </summary>
    class Life:Thing
    {
        readonly private string name;
        readonly private DateTime birthDay = new DateTime();
        
        public DateTime BirthDay
        {
            get { return birthDay; }
        }
        public string Name
        {
            get { return name; }
        }
        public Life(DateTime bd,string n,float w,float h,float d,float we):base(n, w, h, d, we)
        {
            this.birthDay = bd;
            this.name = n;
        }
        public bool GetBirthDay()
        {
            if(BirthDay.Date == DateTime.Today.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
