using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Semana2_Ejercicio1
{
    public class Triangle : Figure
    {
        private float b;
        private float h;

        public Triangle(float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        
        public override float GetArea()
        {
            return b * h / 2;
        }
    }
}