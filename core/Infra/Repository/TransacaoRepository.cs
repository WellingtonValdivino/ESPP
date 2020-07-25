using System.Collections.Generic;

namespace core.Infra.Repository
{
    using System;
    using Dapper;
    using core.Domain;    
    using core.Domain.Entities;
    using core.Domain.Interfaces;
    using core.Infra.Repository;

    public class TransacaoRepository : ITransacaoRepository
    {
        private readonly IRepositoryBase _RepositoryBase;

        public TransacaoRepository(IRepositoryBase Repository)
        {
            _RepositoryBase = Repository;
        }

        public IEnumerable<Transacao> ConsultaTransacao(string filtro)
        {
            var conn = _RepositoryBase.conn();
            var sql = @"select  
                id_transacao AS idTransacao, 
                data_transacao AS dataTransacao, 
                tipo_transacao AS tipoTransacao, 
                valor_transacao AS valorTransacao 
                from tb_transacao where id_transacao = " + filtro;

            return conn.Query<Transacao>(sql);
        }
        
        public IEnumerable<Transacao> ConsultaTransacao()
        {
            var conn = _RepositoryBase.conn();

            var sql = @"select  
                id_transacao AS idTransacao, 
                data_transacao AS dataTransacao, 
                tipo_transacao AS tipoTransacao, 
                valor_transacao AS valorTransacao 
                from tb_transacao";

            return conn.Query<Transacao>(sql);
        }

        public int InserirTransacao(Transacao _Transacao)
        {
            var conn = _RepositoryBase.conn();
            var val = "";
            var sql = @"insert into tb_transacao (id_transacao, data_transacao, tipo_transacao, valor_transacao) 
                    values(@id_transacao, @data_transacao, @tipo_transacao, @valor_transacao)";
            
            return conn.Execute(sql, new
            {
                id_transacao = _Transacao.idTransacao,
                data_transacao = _Transacao.dataTransacao,
                tipo_transacao = _Transacao.tipoTransacao,
                valor_transacao = _Transacao.valorTransacao
            });
        }

        public int AtualizarTransacao(Transacao _Transacao, string filtro)
        {
            var conn = _RepositoryBase.conn();
            var sql = @"update tb_transacao set 
                id_transacao = @id_transacao, 
                data_transacao = @data_transacao, 
                tipo_transacao = @tipo_transacao, 
                valor_transacao = @valor_transacao 
                where id_transacao = " + filtro;

            return conn.Execute(sql, new
            {
                 id_transacao = _Transacao.idTransacao, 
                 data_transacao = _Transacao.dataTransacao, 
                 tipo_transacao = _Transacao.tipoTransacao, 
                 valor_transacao = _Transacao.valorTransacao  
            });
        }

        public int DeletarTransacao(string filtro)
        {
            var conn = _RepositoryBase.conn();

            var sql = "delete from tb_transacao where id_transacao = " + filtro;
            return conn.Execute(sql); 
        }
    }
}
