using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, div=0;
            Console.WriteLine("Ingrese un numero para saber si es primo");
            num = Convert.ToInt32(Console.ReadLine());  
            for(int i=1; i<=num; i++)
            {
                if(num%i == 0)
                {
                    div++;
                }
            }

            Console.Clear();
           if (div > 2)
            {
                Console.WriteLine("El numero no es primo");
            }
            else
            {
                Console.WriteLine("El numero es primo");
            }

            Console.ReadKey();
            
        }
    }
}
