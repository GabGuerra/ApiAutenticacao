using ApiAutenticacao.DataAccess;
using ApiAutenticacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAutenticacao.Business
{
    public class AutenticacaoBL 
    {
        private AutenticacaoDAO dao;

        public AutenticacaoBL()
        {
            dao = new AutenticacaoDAO();
        }        
        public ResultadoAutenticacao VerificarPermissao(string cpf, int codModulo)
        {
            ResultadoAutenticacao res = new ResultadoAutenticacao();
            try
            {
                dao.SalvarHistoricoAutenticao(new HistoricoAutenticacao(cpf,codModulo));
                res.Sucesso = dao.VerificarPermissao(cpf, codModulo);                
            }
            catch (Exception ex)
            {
                res.Sucesso = false;
                res.Mensagem = $"Não foi possível verificar permissão. {Environment.NewLine} {ex.Message}";
            }
            res.Mensagem = res.Sucesso ? "Acesso liberado." : "Você não tem permissão para acessar este módulo.";
            return res;
        }     
        

    }
}