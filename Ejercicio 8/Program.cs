using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8_Guia_6_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota, insuficiente=0, bueno=0, notas=0, notassuma=0, noaprobados=0, aprobados=0;
            double promedio;
            do
            {
                Console.WriteLine("Ingresar nota [-1] para salir");
                nota = int.Parse(Console.ReadLine());
                if (nota != -1)
                {
                    notas++;
                    notassuma = notassuma + nota;
                    if (nota < 6)
                    {
                        noaprobados++;
                    }
                    else if (nota > 5)
                    {
                        aprobados++;
                    }
                    if (nota >= 8)
                    {
                        bueno++;
                    }
                    else if (nota < 4)
                    {
                        insuficiente++;
                    }
                }
                
                
            } while(nota != -1);

            promedio = notassuma / notas;
            double porcentaje1 = (bueno * 100) / notas;
            double porcentaje2 = (insuficiente * 100) / notas;

            Console.WriteLine($"La cantidad de notas subidas fueron de {notas}, con un promedio de {promedio}.\nLa cantidad de aprobados fueron de {aprobados} alumnos y la cantidad de desaprobados de {noaprobados} alumnos.\nHubo un porcentaje de alumnos con {porcentaje1}% muy bueno y de {porcentaje2}% insuficiente.");
            Console.ReadKey();
        }
    }
}
