using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.Models
{
    public class Itinerario
    {
        public List<Cliente> Entregas { get; set; }



        public Itinerario(Cliente clientes)
        {

            var entregas = new List<Cliente>();

            foreach(var i in entregas)
            {
                double x = clientes.Latitude;
                double y = clientes.Longitude;


            }
        }
    }
}

