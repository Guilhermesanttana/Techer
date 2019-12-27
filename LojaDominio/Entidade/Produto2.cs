using System;
using System.Collections.Generic;

namespace LojaDominio.Entidade
{
    public class Produto2
    {

        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Categoria { get; set; }


        private List<Produto2> _produtos;

        public Produto2()
        {
            _produtos = new List<Produto2>();
        }
        

        public List<Produto2> ListarFrutas()
        {
            _produtos.Add(new Produto2() { Nome = "Banana", Valor = 5, Categoria = "Frutas" });
            _produtos.Add(new Produto2() { Nome = "Morango", Valor = 10, Categoria = "Frutas" });
            _produtos.Add(new Produto2() { Nome = "Pera", Valor = 15, Categoria = "Frutas" });
            _produtos.Add(new Produto2() { Nome = "Abacaxi", Valor = 8, Categoria = "Frutas" });
            _produtos.Add(new Produto2() { Nome = "Melão", Valor = 13, Categoria = "Frutas" });

            return _produtos;
        }

        public List<Produto2> ListarEletronicos()
        {
            _produtos.Add(new Produto2() { Nome = "IPhone", Valor = 8000, Categoria = "Eletronicos" });
            _produtos.Add(new Produto2() { Nome = "Samsung", Valor = 2000, Categoria = "Eletronicos" });
            _produtos.Add(new Produto2() { Nome = "Motorola", Valor = 1500, Categoria = "Eletronicos" });

            return _produtos;
        }






    }
}
