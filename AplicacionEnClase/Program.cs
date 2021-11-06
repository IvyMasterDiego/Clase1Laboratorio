using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEnClase
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int limit = 10;
            int auxiliar;
            int primo = 2;
            for (int i = 0; i < limit; i++)
            {
                primo++;
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                //Console.WriteLine(a);
                if ((a % 2) == 0 && a % primo == 0)
                {
                    Console.WriteLine(a + " || Par || Primo");
                }
                else
                {
                    Console.WriteLine(a + "|| Impar || No es primo");
                }
            }
            Console.ReadKey();
        }
    }
}
