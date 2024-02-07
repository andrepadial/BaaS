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
using BaaS.App.Autbank;
using Microsoft.Extensions;

namespace BaaS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfobankController : ControllerBase
    {
        private readonly IInfobankApp infobankApp;
        private readonly ILogger<InfobankController> _logger;

        public InfobankController (IInfobankApp _infobankApp, ILogger<InfobankController> logger)
        {
            infobankApp = _infobankApp;
            _logger = logger;
        }

        [HttpPost]
        [Route("ListarEstados")]
        [ProducesResponseType(typeof(IListarModalidadeResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        [SwaggerOperation(Summary = "Obtém a lista de estados do Brasil")]
        public async Task<IActionResult> ListarModalidades()
        {
            try
            {
                _logger.LogInformation("Chamando API de listagem de estados.");
                var result = await infobankApp.ListarEstados();
                _logger.LogInformation("Retorno da API com sucesso.");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Erro na API de listagem de estados:" + ex.Message.ToString());
                throw new Exception(ex.Message.ToString());
            }
        }

        [HttpPost]
        [Route("ListarEnderecos")]
        [ProducesResponseType(typeof(IListarEnderecoClienteResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        [SwaggerOperation(Summary = "Obtém a lista de endereços do cliente")]
        public async Task<IActionResult> ListarEnderecosCliente(IListarDadosClienteSignature signature)
        {
            try
            {
                var result = await infobankApp.ListarEnderecos(signature);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
