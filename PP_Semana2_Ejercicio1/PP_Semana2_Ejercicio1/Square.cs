using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Semana2_Ejercicio1
{
    public class Square : Figure
    {
        private float side;        

        public Square(float side)
        {
            this.side = side;            
        }

        public override float GetArea()
        {
            return side * side;
        }
    }
}