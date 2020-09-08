using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAutenticacao.Models
{
    public class ResultadoAutenticacao
    {
        public string Mensagem { get; set; }
        public bool Sucesso { get; set; }        
        public object Complemento { get; set; }
    }
}