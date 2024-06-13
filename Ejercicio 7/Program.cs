using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7_Guia_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura, ancho;
            string c = "Presione una tecla para continuar";

            do
            {
                Console.WriteLine("Ingresar ancho del rectangulo o [0] para salir");
                ancho = int.Parse(Console.ReadLine());
                if (ancho != 0)
                {
                    Console.WriteLine("Ingresar Altura del rectangulo");
                    altura = int.Parse(Console.ReadLine());

                    if (ancho >= altura)
                    {
                        for (int i = 0; i <= altura; i++)
                        {
                            for (int a = 0; a <= ancho; a++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\nPara seguir presione una tecla");
                        Console.ReadKey();
                    }
                    else if (ancho < altura)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.SetCursorPosition(43, 15);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"El Alto no puede ser mayo al ancho\n\n{c,76:f0}");
                        Console.ReadKey();
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
            
            } while (ancho != 0);
             
        }
    }
}

       
      