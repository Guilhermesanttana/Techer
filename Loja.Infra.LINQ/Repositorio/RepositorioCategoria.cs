using Loja.Infra.LINQ;
using System.Linq;

namespace Loja.Infra.LINQ.Repositorio
{
    class RepositorioCategoria
    {
        public void AdicionarCategoria(int id, string nome)
        {
            //LINQ to SQL
            Categoria categoria = new Categoria();
            categoria.Id = id;
            categoria.Nome = nome;


            LojaLinqToSqlDataContext linq = new LojaLinqToSqlDataContext();
            linq.Categorias.InsertOnSubmit(categoria);

            linq.SubmitChanges();
        }

        public void AlterarCategoria(int id, string nome)
        {
            //LINQ to SQL
            LojaLinqToSqlDataContext linq = new LojaLinqToSqlDataContext();

            var categoria = linq.Categorias.First(x => x.Id == id);

            categoria.Nome = nome;

            linq.SubmitChanges();
        }

    }
}
