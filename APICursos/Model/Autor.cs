using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICursos.Model
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Curso> Cursos { get; set; }

        public Autor()
        {
        }

        public Autor(String name)
        {
            this.Name = name;
        }
    }
}
