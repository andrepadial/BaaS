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
    public class PixController : ControllerBase
    {
        private readonly IPixApp pixApp;

        public PixController(IPixApp _pixApp)
        {
            this.pixApp = _pixApp;
        }

        [HttpPost]
        [Route("ListarMovimentosPix")]
        [ProducesResponseType(typeof(IListarMovimentosPixResult), (int)HttpStatusCode.OK)]
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        [SwaggerOperation(Summary = "Obtém a lista de movimentos de PIX em um período")]
        public async Task<IActionResult> ListarMovimentos(IListarMovimentosPixSignature signature)
        {
            try
            {
                var result = await pixApp.ListarMovimentos(signature);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
