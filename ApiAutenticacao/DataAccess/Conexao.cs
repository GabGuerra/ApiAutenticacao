using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAutenticacao.DataAccess
{
    public class Conexao
    {
        public MySqlConnection ObterConexao()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=AUTENTICACAO;uid=root;password=; convert zero datetime=True");
            return con;
        }
    }
}