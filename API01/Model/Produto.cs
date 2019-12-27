using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API01
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataValidade { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public int Categoria { get; set; }

    }
}
