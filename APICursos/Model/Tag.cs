﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICursos.Model
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<TagCurso> Cursos { get; set; }
    }
}

