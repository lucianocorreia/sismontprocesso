using SismontProcessos.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Xerife.Data;

namespace SismontProcessos.Controllers
{
    public class RequisicaoValueController : ValuesController
    {
        [HttpGet]
        public IQueryable<xerife_requisicao> GetRequisicao()
        {
            return Get<xerife_requisicao>();
        }

        [HttpGet]
        public IQueryable<xerife_requisicao> GetRequisicao(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("requisicao_id", id);
            return Get<xerife_requisicao>(parameters);
        }

        [HttpPut]
        public void Update([FromBody]xerife_requisicao requisicao)
        {
            var original = _context.xerife_requisicao.FirstOrDefault(x => x.requisicao_id == requisicao.requisicao_id);
            DoUpdate<xerife_requisicao>(requisicao, original);
        }

        [HttpPost]
        public void AdicionarFuncionario([FromBody]dynamic value)
        {
            
            if (value!= null)
            {
                xerife_requisicao requisicao = null;
                string tipo = value.tipo_requisicao.ToString() ?? string.Empty;
                switch(tipo)
                {
                    case "funcionario": requisicao = FuncionarioModel.CreateObject(value);
                        break;
                    case "ferias": requisicao = FeriasModel.CreateObject(value);
                        break;
                    case "rescisao": requisicao = RescisaoModel.CreateObject(value);
                        break;
                }
                if(requisicao!=null)
                {
                    DoPost<xerife_requisicao>(requisicao);
                    try
                    {
                        _context.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
    }
}
