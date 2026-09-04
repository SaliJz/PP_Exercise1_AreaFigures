using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Semana2_Ejercicio1
{
    public class Rectangle : Figure
    {
        private float baseLength;
        private float height;

        public Rectangle(float baseLength, float height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override float GetArea()
        {
            return baseLength * height;
        }
    }
}