using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1;
            Console.WriteLine("Ingrese valor 1 y valor 2 del intervalo");
            num = Convert.ToInt32(Console.ReadLine());
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num > num1)
            {
                int aux = num;
                num = num1;
                num1 = aux;
            }
            Console.Clear();
            for (int i=num; i<num1; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            
        }
    }
}
