using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeIncidente.Models
{
    public class Interacao
    {
        [Key]
        public int IdInteracao { get; set; }
        public string Descricao { get; set; }
        
        public DateTime DataInteracao { get; set; }
        public int IncidenteIdIncidente { get; set; }




        public Interacao()
        {
            this.DataInteracao = DateTime.Now;
        }

        public Interacao(string descricao, DateTime dataInteracao, int IdIncidente)
        {            
            this.Descricao = descricao;
            this.DataInteracao = DateTime.Now;
            this.IncidenteIdIncidente = IdIncidente;

        }  
    }
}
