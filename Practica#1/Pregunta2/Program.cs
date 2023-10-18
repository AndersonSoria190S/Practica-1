using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    internal class Program
    {
        static bool esPrimo(int n)
        {
            int cont = 0;
            for (int i = 1; i <= n; i++) 
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            return cont == 2;
        }

        static bool EsPerfecto(int n)
        {
            int suma = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) suma += i;
            }
            return suma == n;
        }

        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int n;
            Console.WriteLine("Ingrese el el numero n para la lista");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i+1));
                int entrada = int.Parse(Console.ReadLine());
                numeros.Add(entrada);
            }

            ////LISTAS 
            List<int> multiplos2 = new List<int>();
            List<int> primos = new List<int>();
            List<int> multiplos5 = new List<int>();
            List<int> perfectos = new List<int>();

            foreach (int i in numeros)
            {
                if (i % 2 == 0)
                {
                    multiplos2.Add(i);
                }
                if (esPrimo(i))
                {
                    primos.Add(i);
                }
                if (i % 5 == 0)
                {
                    multiplos5.Add(i);
                }
                if (EsPerfecto(i))
                {
                    perfectos.Add(i);
                }
            }
            ////MOSTRAR MULTIPLOS DE 2
            Console.Write ("Lista 1:");
            foreach (int i in multiplos2)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine("");
            Console.Write("Lista 2:");
            foreach (int i in primos)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine("");
            Console.Write("Lista 3:");
            foreach (int i in multiplos5)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine("");
            Console.Write("Lista 4:");
            foreach (int i in perfectos)
            {
                Console.Write(" {0} ", i);
            }
            ///MOSTRAR PRIMOS
            ///MOSTAR MULTIPLOS DE 5
            ///MOSTRAR PERFECTOS
            Console.ReadKey();
        }
    }
}
