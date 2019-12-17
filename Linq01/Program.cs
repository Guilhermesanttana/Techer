using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numeros2 = { 1, 3, 8, 10, 4, 13, 7, 2, 18, 10 };

            //Exemplo Lambda
            var numerosFiltrados = numeros.Where(n => n > 4);

            //Exemplo sintaxe LINQ (tipo Query)
            var resultado = from num in numeros
                            where num > 4
                            select num;

            //Exemplo 2 OrderBy
            var resultado2 = from num in numeros2
                             where num > 4
                             orderby num
                             select num;

            //Exemplo 3 OrderBy
            var resultado3 = numeros.Where(n => n > 4).OrderBy(x => x);

            foreach (int numero in resultado3)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
            */


            // -------------------------- ** -------------------------- //

            string[] cores = { "Preto", "Branco", "Azul", "Amarelo", "Vermelho" };

            //Exemplo Contains
            var resultado = cores.Where(x => x.Contains("e"));

            foreach (string cor in resultado)
            {
                Console.WriteLine(cor);
            }
            Console.WriteLine("----------------------------");


            //Exemplo "ou" ||
            var resultado2 = cores.Where(x => x.Contains("e") || x.Contains("z"));

            //Exemplo "e" &&
            var resultado3 = cores.Where(x => x.Contains("e") && x.Contains("z"));

            foreach (string cor in resultado2)
            {
                Console.WriteLine(cor);
            }
            Console.WriteLine("----------------------------");
            Console.ReadKey();
        }
    }
}
