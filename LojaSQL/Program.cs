//using Loja.Infra.LINQ.Repositorio;

using System;

namespace LojaSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Salvando categoria com EntityFramework
            //new Loja.Infra.EntityFramework.Repositorio.RepositorioCategoria().AdicionarCategoria(1, "Frutas");
            //new Loja.Infra.EntityFramework.Repositorio.RepositorioCategoria().AdicionarCategoria(2, "Eletronicos");

            //Alterar categoria com EntityFramework
            //new Loja.Infra.EntityFramework.Repositorio.RepositorioCategoria().AlterarCategoria(1, "Verduras");

            //Excluir categoria com EntityFramework
            //new Loja.Infra.EntityFramework.Repositorio.RepositorioCategoria().ExcluirCategoria(1);

            //Listar produtos com EntityFramework
            var produtosEF = new Loja.Infra.EntityFramework.Repositorio.RepositorioCategoria().ListarProdutos();
            produtosEF.ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();



            //Salvando categoria com LINQ to SQL
            //new Loja.Infra.Linq.Repositorio.RepositorioCategoria().AdicionarCategoria(3, "Roupas");
            //new Loja.Infra.Linq.Repositorio.RepositorioCategoria().AdicionarCategoria(4, "Cozinha");

            //Alterar categoria com LINQ to SQL
            //new Loja.Infra.LINQ.Repositorio.RepositorioCategoria().AlterarCategoria(4, "Infantil");
        }
    }
}
