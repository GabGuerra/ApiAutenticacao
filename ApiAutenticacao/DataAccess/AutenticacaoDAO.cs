using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAutenticacao.DataAccess
{
    public class AutenticacaoDAO
    {
        public bool VerificarPermissao(string cpf, int codModulo)
        {
            var conexaoBD = new Conexao();
            var conn = conexaoBD.ObterConexao();
            conn.Open();
           
            string strSql = @"SELECT
                                  COUNT(1) > 0
                              FROM
                                  USUARIO U
                              INNER JOIN PERFIL_MODULO PM ON U.COD_PERFIL = PM.COD_PERFIL
                              WHERE
                                  U.CPF = @CPF
                              AND PM.COD_MODULO = @COD_MODULO";

            MySqlCommand sql = new MySqlCommand(strSql, conn);


            sql.Parameters.AddWithValue("@CPF", cpf);
            sql.Parameters.AddWithValue("@COD_MODULO", codModulo);            

            return Convert.ToBoolean(sql.ExecuteScalar());
           
            
        }
    }
}