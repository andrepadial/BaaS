using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.App.Autbank.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace BaaS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EBankController : ControllerBase
    {
        private readonly IEBankApp ebankApp;

        public EBankController(IEBankApp _ebankApp)
        {
            ebankApp = _ebankApp;
        }

        [HttpGet]
        [Route("ListarModalidades")]
        [ProducesResponseType(typeof(IListarModalidadeResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [SwaggerOperation(Summary = "Obtém a lista de modalidades do EBank")]
        public async Task<IActionResult> ListarModalidades()
        {
            try
            {
                var result = await ebankApp.ListarModalidades();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("ListarModalidade")]
        [ProducesResponseType(typeof(IListarModalidadeResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        public async Task<IActionResult> ListarModalidade(IListarModalidadeSignature signature)
        {
            try
            {
                var result = await ebankApp.ListarModalidade(signature);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpPost]
        [Route("CadastrarConta")]
        [ProducesResponseType(typeof(ICadastrarContaResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        public async Task<IActionResult> CadastrarConta(ICadastrarContaSignature signature)
        {
            try
            {
                var result = await ebankApp.IncluirConta(signature);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("ListarSaldoConta")]
        [ProducesResponseType(typeof(ICadastrarContaResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [SwaggerOperation(Summary = "Obtém o saldo da conta pesquisada")]
        public async Task<IActionResult> ListarSaldoConta(IListarSaldoContaSignature signature)
        {
            try
            {
                var result = await ebankApp.ListarSaldoConta(signature);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("ListarHistoricos")]
        [ProducesResponseType(typeof(IListarHistoricoContaResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [SwaggerOperation(Summary = "Obtém a lista de histtóricos do EBank")]
        public async Task<IActionResult> ListarHistoricos()
        {
            try
            {
                var result = await ebankApp.ListarHistoricos();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("ListarHistorico")]
        [ProducesResponseType(typeof(IListarHistoricoContaResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [SwaggerOperation(Summary = "Obtém o histórico de conta do EBank")]
        public async Task<IActionResult> ListarHistorico(IListarHistoricoContaSignature signature)
        {
            try
            {
                var result = await ebankApp.ListarHistorico(signature);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
