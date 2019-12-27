using LojaDominio.Entidade;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {

            //  -----------------------------------------------------  //
            // Objetos Complexos - Aula 03

            /*
            var produto = new Produto();
            
            //Exemplo Where (valor > 4)
            var produtos = produto.Listar().Where(p => p.Valor > 4);

            foreach(Produto item in produtos)
            {
                Console.WriteLine(item.Nome);
            }
            Console.ReadKey();

            //Single line
            new Produto().Listar().ForEach(item => Console.WriteLine(item.Nome));
            Console.ReadKey();

            //Multi operação
            new Produto().Listar().ForEach(item =>
            {
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Valor);
            });
            Console.ReadKey();

            //Precisamos converter pra lista pq o IEnumerable não suporta o ForEach desse jeito ai
            new Produto().Listar().Where(p => p.Valor > 4).ToList().ForEach(item =>
            {
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Valor);
            });
            Console.ReadKey();*/






            //  -----------------------------------------------------  //
            //Objetos Complexos com Funções - Aula 04
            /*
            var produtos = new Produto().Listar();

            var produtos2 = new Produto().Listar();


            //Lista os produtos que contem a letra "M"
            produtos = produtos.Where(p => p.Nome.Contains("M")).ToList();
            produtos.ForEach(item => Console.WriteLine(JsonConvert.SerializeObject(item)));
            Console.ReadKey();


            //Lista os produtos que (StartWith) Começa com a letra "M" ou (EndsWith) Termina com "o"
            produtos2 = produtos2.Where(p => p.Nome.StartsWith("M") || p.Nome.EndsWith("a")).ToList();
            produtos2.ForEach(item => Console.WriteLine(JsonConvert.SerializeObject(item)));
            Console.ReadKey();


            //Lista os nomes dos produtos que (StartWith) Começa com a letra "M" ou (EndsWith) Termina com "o"
            var nomes = produtos.Where(p => p.Nome.StartsWith("M") || p.Nome.EndsWith("o"))
                               .Select(p => p.Nome)
                               .ToList();
            nomes.ForEach(item => Console.WriteLine(item));
            Console.ReadKey();


            //Lista os nomes dos produtos apenas com as 3 primeiras letras usando o metodo ProdutoSelecionado
            var nomes2 = produtos.Where(p => p.Nome.StartsWith("M") || p.Nome.EndsWith("o"))
                               .Select(p => new ProdutoSelecionado { Name = p.Nome.Substring(0,3), Value = p.Valor })
                               .ToList();

            nomes2.ForEach(item =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            });
            Console.ReadKey();
            

            //Lista os nomes dos produtos e insere "GUI" aparir do index de caracter 2 usando o metodo ProdutoSelecionado
            var nomes3 = produtos.Where(p => p.Nome.StartsWith("M") || p.Nome.EndsWith("o"))
                               .Select(p => new ProdutoSelecionado { Name = p.Nome.Insert(2,"GUI"), Value = p.Valor })
                               .ToList();

            nomes3.ForEach(item =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            });
            Console.ReadKey();


            //Ainda existem os comandos            
            //Remove(2,2)       -> A partir do index 2 ele remove 2 caracteres
            //Replace("a", "Z") -> Substitua a letra "a" por "Z"                        

            
            // DateTime
            //Imprime uma lista de produtos que tem o DataVencimento > 3
            var nomes = produtos.Where(p => p.DataVencimento.Day > 3)
                              .Select(p => new ProdutoSelecionado { Name = p.Nome, Value = p.Valor, DiaDeVencimento = p.DataVencimento.Day })
                              .ToList();

            nomes.ForEach(item =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            });
            Console.ReadKey();

            */






            //  -----------------------------------------------------  //
            //Pesquisa - Aula 05
            /*
            var produtos = new Produto().Listar();

            
            //Retorna o primeiro item da lista e se a lista estiver vazia ele preenche com NULL
            var produto1 = produtos.FirstOrDefault();

            //Retorna o primeiro item da lista e se a lista estiver vazia da Exception 
            var produto2 = produtos.First();

            //Retorna o ultimo item da lista e se a lista estiver vazia ele preenche com NULL
            var produto3 = produtos.LastOrDefault();

            //Retorna o ultimo item da lista e se a lista estiver vazia da Exception 
            var produto4 = produtos.Last();

            //Verifica se tem alguma coisa na lista
            if(produtos.Any())
            {
                Console.WriteLine("Tem itens");
            }

                        
            var produtos2 = new List<Produto>();
            produtos2.Add(new Produto() { Nome = "Galaxy", Valor = 2500 });
            produtos2.Add(new Produto() { Nome = "IPhone", Valor = 10000 });

            //Adiciona uma lista ao final de outra lista
            produtos.AddRange(produtos2);
            produtos.ForEach(x => Console.WriteLine(x.Nome));

            
            int[] numerosPares = { 2, 4, 6, 8, 10 };
            int[] numerosImpares = { 1, 3, 5, 7, 9 };
            int[] numerosMistos = { 1, 2, 3, 4 };

            //Verifica se tem numeros iguais nas duas listas (interseção)
            var numeroQueSeRepetem = numerosMistos.Intersect(numerosPares);

            //Verifica se tem numeros diferentes nas duas listas (exceção)
            var numerosQueNaoSeRepetem = numerosMistos.Except(numerosPares);

            //Cria um Enumerable com 10, 11 e 12
            var sequencia = Enumerable.Range(10, 3);

            //Repete a string "Gui" 10 vezes
            var repetir = Enumerable.Repeat("Gui", 10);

            //Valor produto mais caro
            var valorProdutoMaisCaro = produtos.Max(x => x.Valor);

            //Valor produto mais barato
            var valorProdutoMaisBarato = produtos.Min(x => x.Valor);

            //Media do valor dos produtos
            var mediaValorProdutos = produtos.Average(x => x.Valor);

            //Soma dos valores dos produtos
            var somaValorProdutos = produtos.Sum(x => x.Valor);

            Console.ReadKey();*/





            //  -----------------------------------------------------  //
            //Agrupamento e Agregação - Aula 06

            var produtosFrutas = new Produto2().ListarFrutas();
            var produtosEletronicos = new Produto2().ListarEletronicos();

            var produtos = new List<Produto2>();
            produtos.AddRange(produtosEletronicos);
            produtos.AddRange(produtosFrutas);

            produtos.ForEach(x =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(x));
            });

            Console.WriteLine("---------------------------------------------");

            //Super consulta haha
            var resultado = (from p in produtos
                            group p by p.Categoria into grupo
                            select new RelatorioProdutoPorCategoria
                            {
                                NomeDaCategoria = grupo.Key,
                                ValorMinimo = grupo.Min(x => x.Valor),
                                ValorMaximo = grupo.Max(x => x.Valor),
                                ValorTotal = grupo.Sum(x => x.Valor)
                            }).OrderBy(x => x.NomeDaCategoria);

            resultado.ToList().ForEach(x =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(x));
            });

            Console.ReadKey();
        }
    }

    public class RelatorioProdutoPorCategoria
    {
        public string NomeDaCategoria { get; set; }
        public decimal ValorMinimo { get; set; }
        public decimal ValorMaximo { get; set; }
        public decimal ValorTotal { get; set; }
    }


public class ProdutoSelecionado
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int DiaDeVencimento { get; set; }

        /*
        public void ImprimeProduto(string name, decimal value)
        {
            Name = name;
            Value = value;
            
            Console.WriteLine(Name);
            Console.WriteLine(Value);
        }*/
    }
}


//350 158 200