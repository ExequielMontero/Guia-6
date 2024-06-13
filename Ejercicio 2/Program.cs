using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2__Guia_6
{
    class Program
    {
        static void Main()
        {
            // Dimensiones del marco
            int x1 = 5, y1 = 2;
            int x2 = 75, y2 = 22;

            // Llamar a la función para dibujar el marco
            DibujarMarco(x1, y1, x2, y2);
        }

        static void DibujarMarco(int x1, int y1, int x2, int y2)
        {
            // Crear una matriz de caracteres inicializada con espacios
            int ancho = x2 + 1;
            int altura = y2 + 1;
            char[,] pantalla = new char[altura, ancho];

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    pantalla[i, j] = ' ';
                }
            }

            // Dibujar líneas horizontales
            for (int x = x1; x <= x2; x++)
            {
                pantalla[y1, x] = '*';
                pantalla[y2, x] = '*';
            }

            // Dibujar líneas verticales
            for (int y = y1; y <= y2; y++)
            {
                pantalla[y, x1] = '*';
                pantalla[y, x2] = '*';
            }

            // Imprimir la pantalla
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    Console.Write(pantalla[y, x]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    }
