using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    class Student:Person
    {
        public string id;
        public string ID
        {
            get { return id; }
        }
        /// <summary>
        /// 生徒
        /// </summary>
        /// <param name="i">出席番号</param>
        /// <param name="bd">誕生日</param>
        /// <param name="n">名前</param>
        /// <param name="w">重さ</param>
        /// <param name="h"></param>
        /// <param name="d"></param>
        /// <param name="we"></param>
        public Student(string i,DateTime bd,string n,float w,float h,float d,float we) : base(bd, n, w, h, d, we)
        {
            id = i;
        }
    }
}
