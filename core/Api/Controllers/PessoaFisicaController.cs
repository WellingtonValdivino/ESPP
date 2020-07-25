using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using System.Web.Http;

namespace core.Api.Controllers
{
    using core.Domain.Entities;
    using core.Domain.Interfaces;
    using core.Service;
    using core.Api.Model.Components;
    
    [Route("api/contadigital/[controller]")]
    [ApiController]
    public class PessoaFisicaController : ControllerBase
    {
        protected readonly IPessoaFisicaService _PessoaFisicaService;

        public PessoaFisicaController(IPessoaFisicaService clienteService)
        {
            _PessoaFisicaService = clienteService;
        }
        
        [HttpGet]
        [Produces(typeof(PessoaFisica))]
        public IActionResult Get()
        {
            try
            {
                var consultar = _PessoaFisicaService.ConsultaPessoaFisica().ToList();

                if (consultar.Count() == 0)
                {
                    return NoContent();
                }
                else
                {
                    return Ok(consultar);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
      
        [HttpGet("{PessoaFisicaId}")]
        public IActionResult Get(string PessoaFisicaId)
        {
            try
            {
                var consultar =  _PessoaFisicaService.ConsultaPessoaFisica(PessoaFisicaId);
                
                if (consultar.Count() == 0)
                {
                    return NoContent();
                }
                else
                {
                    return Ok(consultar);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] PessoaFisica _PessoaFisica)
        {
            try
            {               
                int id = _PessoaFisicaService.InserirPessoaFisica(_PessoaFisica);

                if (id == 0)
                {
                    return NoContent();
                }
                else
                {
                    return Ok();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{PessoaFisicaId}")]
        public IActionResult Put( [FromBody] PessoaFisica _PessoaFisica, string PessoaFisicaId)
        {
            try
            {
                int id = _PessoaFisicaService.AlterarPessoaFisica(_PessoaFisica, PessoaFisicaId);

                if (id == 0)
                {
                     return NoContent();
                }
                else
                {
                       return Ok(id.ToString());
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
     
        [HttpDelete("{PessoaFisicaId}")]
        public IActionResult DeletarPessoaFisica(string PessoaFisicaId)
        {
           try
            {
                int id = _PessoaFisicaService.DeletarPessoaFisica(PessoaFisicaId);

                if (id == 0)
                {
                     return NoContent();
                }
                else
                {
                     return Ok();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
