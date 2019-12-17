using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeIncidente.Models
{
    public class Incidente
    {
        [Key]
        public int IdIncidente { get; set; }
        [MaxLength(40)]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Prazo { get; set; }
        public int Situacao { get; set; }

        public List<Interacao> Interacoes { get; set; }





    }
}
