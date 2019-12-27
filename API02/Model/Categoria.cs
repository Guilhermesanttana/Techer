﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API02.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<Produto> Produtos { get; set; }
    }
}
