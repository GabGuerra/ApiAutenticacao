using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAutenticacao.Models
{
    public class HistoricoAutenticacao
    {
        public int Codigo { get; set; }
        public Usuario Usuario { get; set; }
        public Modulo Modulo { get; set; }
        public DateTime DataRegistro { get; set; }
        public HistoricoAutenticacao(string CpfUsuario, int CodModulo)
        {
            Usuario = new Usuario();
            Modulo = new Modulo();
            Usuario.Cpf = CpfUsuario;
            Modulo.Codigo = CodModulo;        
        }
    }


}