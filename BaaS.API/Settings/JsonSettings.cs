using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Globalization;
using BaaS.Interfaces;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models;
using BaaS.Models.Autbank.Signatures;


namespace BaaS.API.Settings
{
    public class JsonSettings
    {
        public static void SetJsonOptions(MvcNewtonsoftJsonOptions obj)
        {
            obj.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            obj.SerializerSettings.Formatting = Formatting.None;
            obj.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            obj.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            obj.SerializerSettings.ContractResolver = new DefaultContractResolver();
            obj.SerializerSettings.Culture = CultureInfo.CurrentCulture;
            obj.SerializerSettings.Converters = new List<JsonConverter>()
            {
                new AbstractConverter<ICadastrarContaSignature,CadastrarContaSignature >(),
                new AbstractConverter<IListarModalidadeSignature,ListarModalidadeSignature >(),
                new AbstractConverter<IListarSaldoContaSignature,ListarSaldoContaSignature >(),
                new AbstractConverter<IListarMovimentosPixSignature,ListarMovimentosPixSignature >(),

            };
        }
    }
}
