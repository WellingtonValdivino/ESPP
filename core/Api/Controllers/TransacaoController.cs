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
    public class TransacaoController : ControllerBase
    {
        protected readonly ITransacaoService _TransacaoService;

        public TransacaoController(ITransacaoService clienteService)
        {
            _TransacaoService = clienteService;
        }

        
        [HttpGet]
        [Produces(typeof(Transacao))]
        public IActionResult Get()
        {
            try
            {
                var consultar = _TransacaoService.ConsultaTransacao().ToList();

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

        [HttpGet("{TransacaoId}")]
        public IActionResult Get(string TransacaoId)
        {
            try
            {
                var consultar =  _TransacaoService.ConsultaTransacao(TransacaoId);
                
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
        public IActionResult Post([FromBody] Transacao _Transacao)
        {
            try
            {               
                int id = _TransacaoService.InserirTransacao(_Transacao);

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

        [HttpPut("{TransacaoId}")]
        public IActionResult AlterarTransacao( [FromBody] Transacao _Transacao, string TransacaoId)
        {
            try
            {
                int id = _TransacaoService.AlterarTransacao(_Transacao, TransacaoId);

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

     
        [HttpDelete("{TransacaoId}")]
        public IActionResult DeletarTransacao(string TransacaoId)
        {
            try
            {
                int id = _TransacaoService.DeletarTransacao(TransacaoId);
    
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
