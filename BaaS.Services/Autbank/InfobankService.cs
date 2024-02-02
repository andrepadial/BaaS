﻿using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
using BaaS.Repositories.Autbank.Interfaces;
using BaaS.Services.Autbank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Services.Autbank
{
    public class InfobankService : IInfobankService
    {

        private readonly IInfobankRepository repositorio;

        public InfobankService(IInfobankRepository _repositorio)
        {
            repositorio = _repositorio;
        }

        public async Task<IList<ListarEstadosResult>> ListarEstados()
        {
            return await repositorio.ListarEstados();
        }
    }
}