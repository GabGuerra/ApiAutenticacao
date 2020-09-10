using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAutenticacao.Models
{
    public class Usuario
    {
        public string Cpf { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        //adicionar perfil.
        public Usuario() { }
    }
}