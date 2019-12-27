using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICursos.Model
{
    public class TagCurso
    {
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }


        public TagCurso()
        { }
    }
}
