using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio_9_Guia_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cant=0;
            double precio, total=0;

            do
            {
                Console.WriteLine("Ingresar codigo de producto o [0] para salir");
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    Console.WriteLine("Ingresar cantidad de pruductos");
                    cant = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar precio del producto");
                    precio = double.Parse(Console.ReadLine());

                    total = (cant * precio);

                    Console.WriteLine($"El total del producto codigo {num} por la cantidad de {cant} productos es de {total:c}");
                }
            }
            while (num != 0);

            Console.ReadKey();
        }
    }
}
