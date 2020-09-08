using ApiAutenticacao.Business;
using ApiAutenticacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAutenticacao.Controllers
{
    public class AutenticacaoController : ApiController
    {        
        [HttpGet]
        public HttpResponseMessage Autentica(string cpf, int codModulo)         
        {
            var res = new AutenticacaoBL().VerificarPermissao(cpf, codModulo);
            if(res.Sucesso)
                return Request.CreateResponse(HttpStatusCode.OK, res);
            else
                return Request.CreateResponse(HttpStatusCode.Forbidden, res);
        }
    }
}
