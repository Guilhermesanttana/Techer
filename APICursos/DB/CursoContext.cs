using APICursos.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICursos.DB
{
    public class CursoContext : DbContext
    {
        public CursoContext(DbContextOptions<CursoContext> options) : base(options)
        {

        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Tag>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<TagCurso>()
                .HasKey(x => new { x.CursoId, x.TagId });
            modelBuilder.Entity<TagCurso>()
                .HasOne(x => x.Curso)
                .WithMany(m => m.Tags)
                .HasForeignKey(x => x.TagId);
            
            modelBuilder.Entity<TagCurso>()
                .HasOne(x => x.Tag)
                .WithMany(e => e.Cursos)
                .HasForeignKey(x => x.CursoId);


                


        }
    }
}
