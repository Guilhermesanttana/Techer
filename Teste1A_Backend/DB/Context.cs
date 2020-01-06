using DeliveryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.DB
{
    public class Context : DbContext
    {

        // Conexão com o BD adicionada no appsettings.json
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Entregador> Entregadores { get; set; }

    }
}
