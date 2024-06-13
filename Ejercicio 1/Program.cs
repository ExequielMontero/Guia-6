using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;


            do
            {
                Console.WriteLine("Ingrese la nota4 que quiere sumar o [-1] para salir");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            } while(num != -1);
            Console.Clear();
            Console.WriteLine($"El total de la suma es {sum}");
            Console.ReadKey();
        }
    }
}
