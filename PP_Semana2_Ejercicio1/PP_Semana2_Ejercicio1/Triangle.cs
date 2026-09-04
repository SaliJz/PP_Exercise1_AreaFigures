using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Figures
{
    class Triangle : Figures
    {
        private float b;
        private float h;

        public Triangle(float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        
        public override float Area()
        {
            return b * h / 2;
        }
    }
}
