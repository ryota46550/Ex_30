using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    /// <summary>
    /// 物体
    /// </summary>
    class Thing
    {
        readonly public string name;
        public float width;
        public float height;
        public float depth;
        public float weight;

        public string Name
        {
            get { return name; }
        }
        public float Width
        {
            get { return width; }
        }
        public float Height
        {
            get { return height; }
        }
        public float Depth
        {
            get { return depth; }
        }
        public float Weight
        {
            get { return weight; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">名前</param>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        /// <param name="d">奥行</param>
        /// <param name="we">重さ</param>
        public Thing(string n = null,float w = 0,float h = 0,float d = 0, float we = 0)
        {
            name = n;
            width = w;
            height = h;
            depth = d;
            weight = we;
        }
    }
}
