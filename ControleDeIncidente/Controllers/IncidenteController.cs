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
    public class IncidenteController : ControllerBase
    {

        private readonly Context _context;
        public IncidenteController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Incidente> GetIncidentes()
        {
            // lista os incidentes e suas respectivas interações
            var Incidentes = _context.Incidentes.Include(x => x.Interacoes).ToList();
            return Incidentes;
        }

        [HttpPost]
        public void PostIncidente(Incidente item)
        {
            // Adiciona um incidente.
            _context.Incidentes.Add(item);

            // Salva no BD.
            _context.SaveChanges();
        }

        [HttpPost("Situacao/{IdIncidente}")]
        public void PostSituacao(Incidente item)
        {

            // Sobrescreve um incidente.            
            var Incidente = _context.Incidentes.First(x => x.IdIncidente == item.IdIncidente);

            Incidente.Situacao = item.Situacao;

            // Salva no BD.
            _context.SaveChanges();
        }

        [HttpPut("{IdIncidente}")]
        public async Task<IActionResult> PutIncidente(int IdIncidente, Incidente item)
        {
            
            if (IdIncidente != item.IdIncidente)
            {
                return BadRequest();
            }

            _context.Incidentes.Update(item);

            await _context.SaveChangesAsync();
            return NoContent();

        }


        [HttpDelete("{IdIncidente}")]
        public async Task<IActionResult> DeleteIncidente(int IdIncidente)
        {

            var Incidente = await _context.Incidentes.Where(p => p.IdIncidente == IdIncidente).Include(x => x.Interacoes).ToListAsync();

            // Deleta as interações do incidente.
            for (int i = 0; i < Incidente[0].Interacoes.Count(); i++)
            {
                _context.Interacoes.Remove(Incidente[0].Interacoes[i]);
            }

            // Deleta a tabela.
            _context.Incidentes.Remove(Incidente[0]);

            // Salva no BD.
            await _context.SaveChangesAsync();
            return NoContent();

        }


        [HttpGet("Interacao/{IdIncidente}")]
        public IEnumerable<Interacao> GetInteracoes(int IdIncidente)
        {
            // lista as interações
            var Interacoes = _context.Interacoes.Where(p => p.IncidenteIdIncidente == IdIncidente).ToList();
            return Interacoes;
        }


        [HttpPost("Interacao/{IdIncidente}")]
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