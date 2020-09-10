using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAutenticacao.DataAccess
{
    public class Conexao : IDisposable
    {
        private static MySqlConnection _conn;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //Para sempre fechar conexões após bloco using
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _conn.Close();
                _conn.Dispose();
            }
        }

        public MySqlConnection ObterConexao()
        {
            if(_conn == null)
                _conn = new MySqlConnection("server=localhost;database=AUTENTICACAO;uid=root;password=f75b5vip; convert zero datetime=True");
            return _conn;
        }
    }
}