using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.Models
{
    public class Entregador
    {
        [Key]
        public int IdEntregador { get; set; }
        [MaxLength (40)]
        public string Nome { get; set; }
        public int Telefone { get; set; }

        public List<Cliente> Clientes { get; set; }
    }
}
