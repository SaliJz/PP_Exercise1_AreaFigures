using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2Progra
{
    internal class Menu
    {
       private void Ejecutar()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("¿Qué figura desea operar?");
                Console.WriteLine("1.Rectángulo");
                Console.WriteLine("2.Cuadrado");
                Console.WriteLine("3.Círculo");
                Console.WriteLine("4.Triángulo");

                int numero = int.Parse(Console.ReadLine());
                float area = 0;

                switch (numero)
                {
                    case 1: /*Rectangulo*/
                        Console.WriteLine("Introduzca la base");
                        int Base = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca la altura");
                        int altura = int.Parse(Console.ReadLine());

                        Rectangle rectangulo = new Rectangle(Base, altura);

                        area = rectangulo.GetArea();

                        break;

                    case 2: /*Cuadrado*/
                        Console.WriteLine("Introduzca el lado");
                        int lado = int.Parse(Console.ReadLine());
                        area = Cuadrado.CalcularArea(lado);

                        break;

                    case 3: /*Circulo*/
                        Console.WriteLine("Introduzca el radio");
                        int radio = int.Parse(Console.ReadLine());
                        area = Circulo.CalcularArea(radio);

                        break;

                    case 4: /*Triangulo*/
                        Console.WriteLine("Introduzca la base");
                        int baseTriangulo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca la altura");
                        int alturaTriangulo = int.Parse(Console.ReadLine());

                        area = Triangulo.CalcularArea(baseTriangulo, alturaTriangulo);

                        break;
                }

                Console.WriteLine($"El area de la figura seleccionada es {area}");
                Console.WriteLine("¿Desea seleccionar una nueva figura?")
            Console.WriteLine("1.Sí");
                Console.WriteLine("2.No");
                int respuesta = int.Parse(Console.ReadLine())

            if (respuesta == 1)
            {
                Console.WriteLine("¿Qué figura desea operar?");
            Console.WriteLine("1.Rectángulo");
            Console.WriteLine("2.Cuadrado");
            Console.WriteLine("3.Círculo");
            Console.WriteLine("4.Triángulo");

            int numero = int.Parse(Console.ReadLine());
            float area = 0;

            switch (numero)
            {
                case 1: /*Rectangulo*/
                        Console.WriteLine("Introduzca la base");
                        int Base = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca la altura");
                        int altura = int.Parse(Console.ReadLine());

                        Rectangle rectangulo = new Rectangle(Base,altura);
                        
                        area = rectangulo.GetArea();

                        break;

                case 2: /*Cuadrado*/
                        Console.WriteLine("Introduzca el lado");
                        int lado = int.Parse(Console.ReadLine());

                            Square cuadrado = new Square(lado);
                            area = cuadrado.GetArea();
                        
                        break;

                case 3: /*Circulo*/
                        Console.WriteLine("Introduzca el radio");
                        int radio = int.Parse(Console.ReadLine());

                        Circle circulo = new Circle(radio);
                            area = circulo.GetArea();

                        break;

                case 4: /*Triangulo*/
                        Console.WriteLine("Introduzca la base");
                        int baseTriangulo= int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca la altura");
                        int alturaTriangulo = int.Parse(Console.ReadLine());

                        Triangle triangulo= new Triangle(baseTriangulo,alturaTriangulo)

                        area = triangulo.GetArea();

                        break;
            }

            Console.WriteLine($"El area de la figura seleccionada es {area}");
            Console.WriteLine("¿Desea seleccionar una nueva figura?")
            Console.WriteLine("1.Sí");
            Console.WriteLine("2.No");
            int respuesta= int.Parse(Console.ReadLine())

            if (respuesta == 1)
            {
               
            }

            else if(respuesta == 2)
            {
                Console.WriteLine("Gracias por probar la aplicación")
                continuar = false;
                   
            }
            
    }
}
