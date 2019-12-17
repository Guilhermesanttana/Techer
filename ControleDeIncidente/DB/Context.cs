using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeIncidente.Models;

namespace ControleDeIncidente.DB
{
    public class Context : DbContext
    {

        // Conexão com o BD adicionada no appsettings.json
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }


        public DbSet<Incidente> Incidentes { get; set; }
        public DbSet<Interacao> Interacoes { get; set; }

    }
}
