using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace APICursos.Model
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public CursoNivel Nivel { get; set; }
        public float Valor { get; set; }
        public Autor Autor { get; set; }
        public List<TagCurso> Tags { get; set; }

    }


}
