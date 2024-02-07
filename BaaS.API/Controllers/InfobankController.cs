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

namespace BaaS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfobankController : ControllerBase
    {
        private readonly IInfobankApp infobankApp;

        public InfobankController (IInfobankApp _infobankApp)
        {
            infobankApp = _infobankApp;
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
                var result = await infobankApp.ListarEstados();
                return Ok(result);
            }
            catch (Exception ex)
            {
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
