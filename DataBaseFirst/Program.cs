using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new DataBaseContext();

            var autores = new List<Authors>();

            autores = dbContext.Authors.Where(x => x.AuthorID == 1).ToList();            

            foreach (var x in autores)
            {
                Console.WriteLine(x.Name);
            }

            Console.ReadKey();

        }
    }
}
