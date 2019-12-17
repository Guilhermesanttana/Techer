using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeIncidente.DB;
using ControleDeIncidente.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleDeIncidente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteracaoController : ControllerBase
    {
        private readonly Context _context;


        public InteracaoController(Context context)
        {
            _context = context;
        }

        

        [HttpGet("{IdIncidente}/Interacao")]
        public IEnumerable<Interacao> GetInteracoes()
        {        
            // lista as interações
            var Interacoes = _context.Interacoes.ToList();


            return Interacoes;
        }

        [HttpPost]
        public async Task<ActionResult<Incidente>> PostIncidente(Interacao item)
        {                           
            // Adiciona uma interação.
            _context.Interacoes.Add(item);

            // Salva no BD.
            await _context.SaveChangesAsync();
            return NoContent();
        }


    }
}