using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            for(int i=0; i<10; i++)
            {
                Console.WriteLine($"Ingrese el numero {i+1}:");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }

            Console.Clear();
            Console.WriteLine($"El total de la suma es {sum}");
            Console.ReadKey();
        }
    }
}
