using BaaS.App.Autbank.Interfaces;
using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
using BaaS.Services.Autbank;
using BaaS.Services.Autbank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.App.Autbank
{
    public class PixApp : IPixApp
    {

        private readonly IPixService service;

        public PixApp(IPixService _service) 
        {
            this.service = _service;
        }
        public async Task<IList<ListarMovimentosPixResult>> ListarMovimentos(IListarMovimentosPixSignature signature)
        {
            return await service.ListarMovimentos(signature);
        }
    }
}
