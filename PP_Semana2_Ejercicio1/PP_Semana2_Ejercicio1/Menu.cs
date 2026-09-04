using PP_Semana2_Ejercicio1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Semana2_Ejercicio1
{
    internal class Menu
    {
       public void Ejecutar()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("¿Qué figura desea operar?");
                Console.WriteLine();
                Console.WriteLine("1.Rectángulo");
                Console.WriteLine("2.Cuadrado");
                Console.WriteLine("3.Círculo");
                Console.WriteLine("4.Triángulo");
                Console.WriteLine();
                Console.Write("Seleccione una figura: ");

                string option = Console.ReadLine();

                Figure figure = null;

                switch (option)
                {
                    case "1": /*Rectangulo*/
                        try
                        {
                            Console.WriteLine("Introduzca la base");
                            float rectangleBase = float.Parse(Console.ReadLine());

                            Console.WriteLine("Introduzca la altura");
                            float rectangleHeight = float.Parse(Console.ReadLine());

                            figure = new Rectangle(rectangleBase, rectangleHeight);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Introduzca valores numéricos válidos.");
                            Console.ReadKey();
                        }

                        break;

                    case "2": /*Cuadrado*/
                        try
                        {
                            Console.WriteLine("Introduzca el lado");
                            float squareSide = float.Parse(Console.ReadLine());

                            figure = new Square(squareSide);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Introduzca un valor numérico válido.");
                            Console.ReadKey();
                        }

                        break;

                    case "3": /*Circulo*/
                        try
                        {
                            Console.WriteLine("Introduzca el radio");
                            float circleRadius = float.Parse(Console.ReadLine());

                            figure = new Circle(circleRadius);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Introduzca un valor numérico válido.");
                            Console.ReadKey();
                        }

                        break;

                    case "4": /*Triangulo*/
                        try
                        {
                            Console.WriteLine("Introduzca la base");
                            float triangleBase = float.Parse(Console.ReadLine());

                            Console.WriteLine("Introduzca la altura");
                            float triangleHeight = float.Parse(Console.ReadLine());

                            figure = new Triangle(triangleBase, triangleHeight);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Introduzca valores numéricos válidos.");
                            Console.ReadKey();
                        }

                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        continue;
                }

                if (figure == null)
                {
                    Console.WriteLine("No se creó la figura. Pulse una tecla para continuar.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Área: " + figure.GetArea());
                Console.WriteLine();

                Console.Write("¿Desea seleccionar otra figura? (S/N): ");
                string answer = Console.ReadLine();

                if (answer.ToUpper() != "S")
                {
                    continuar = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }
    }
}