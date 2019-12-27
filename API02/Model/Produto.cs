using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API02.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCompra { get; set; }
        public int Quantidade { get; set; }
        public float Valor { get; set; }
        public Categoria Categoria { get; set; }

    }


}
