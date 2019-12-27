using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API02.Model;

namespace API02.Data
{
    public class API02Context : DbContext
    {
        public API02Context (DbContextOptions<API02Context> options)
            : base(options)
        {
        }

        public DbSet<API02.Model.Produto> Produtos { get; set; }
        public DbSet<API02.Model.Categoria> Categorias { get; set; }
    }
}
