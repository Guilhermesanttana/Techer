using System;
using System.Collections.Generic;

namespace LojaDominio.Entidade
{
    public class Produto
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }

        public Produto()
        {
            _produtos = new List<Produto>();
        }


        private List<Produto> _produtos;       

        public List<Produto> Listar()
        {
            _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Banana", Quantidade = 5, Valor = 5, DataVencimento = DateTime.Now.AddDays(5) });
            _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Morango", Quantidade = 2, Valor = 10, DataVencimento = DateTime.Now.AddDays(2) });
            _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Pera", Quantidade = 5, Valor = 15, DataVencimento = DateTime.Now.AddDays(10) });
            _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Abacaxi", Quantidade = 1, Valor = 8, DataVencimento = DateTime.Now.AddDays(6) });
            _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Melão", Quantidade = 35, Valor = 13, DataVencimento = DateTime.Now.AddDays(13) });

            return _produtos;
        }




        


    }
}
