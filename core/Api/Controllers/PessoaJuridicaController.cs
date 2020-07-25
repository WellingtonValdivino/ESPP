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
    public class PessoaJuridicaController : ControllerBase
    {
        protected readonly IPessoaJuridicaService _PessoaJuridicaService;

        public PessoaJuridicaController(IPessoaJuridicaService clienteService)
        {
            _PessoaJuridicaService = clienteService;
        }

        [HttpGet]
        [Produces(typeof(PessoaJuridica))]
        public IActionResult Get()
        {
            try
            {
                var consultar = _PessoaJuridicaService.ConsultaPessoaJuridica().ToList();

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

        [HttpGet("{PessoaJuridicaId}")]
        public IActionResult Get(string PessoaJuridicaId)
        {
            try
            {
                var consultar =  _PessoaJuridicaService.ConsultaPessoaJuridica(PessoaJuridicaId);
                
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
        public IActionResult Post([FromBody] PessoaJuridica _PessoaJuridica)
        {
            try
            {               
                int id = _PessoaJuridicaService.InserirPessoaJuridica(_PessoaJuridica);

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

        [HttpPut("{PessoaJuridicaId}")]
        public IActionResult AlterarPessoaJuridica( [FromBody] PessoaJuridica _PessoaJuridica, string PessoaJuridicaId)
        {
            try
            {
                

                int id = _PessoaJuridicaService.AlterarPessoaJuridica(_PessoaJuridica, PessoaJuridicaId);

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

     
        [HttpDelete("{PessoaJuridicaId}")]
        public IActionResult DeletarPessoaJuridica(string PessoaJuridicaId)
        {
           try
            {
                

                int id = _PessoaJuridicaService.DeletarPessoaJuridica(PessoaJuridicaId);

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
