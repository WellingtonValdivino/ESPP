using System.Collections.Generic;

namespace core.Infra.Repository
{
    using System;
    using Dapper;
    using core.Domain;    
    using core.Domain.Entities;
    using core.Domain.Interfaces;
    using core.Infra.Repository;

    public class PessoaFisicaRepository : IPessoaFisicaRepository
    {
        private readonly IRepositoryBase _RepositoryBase;

        public PessoaFisicaRepository(IRepositoryBase Repository)
        {
            _RepositoryBase = Repository;
        }

        public IEnumerable<PessoaFisica> ConsultaPessoaFisica(string filtro)
        {
            var conn = _RepositoryBase.conn();
            var sql = @"select  
                id_PessoaFisica AS idPessoaFisica, 
                nome_PessoaFisica AS nomePessoaFisica, 
                cpf_PessoaFisica AS cpfPessoaFisica 
                from tb_pessoafisica where id_PessoaFisica = " + filtro;

            return conn.Query<PessoaFisica>(sql);

        }
        
        public IEnumerable<PessoaFisica> ConsultaPessoaFisica()
        {
            var conn = _RepositoryBase.conn();

            var sql = @"select  
                id_PessoaFisica AS idPessoaFisica, 
                nome_PessoaFisica AS nomePessoaFisica, 
                cpf_PessoaFisica AS cpfPessoaFisica 
                from tb_pessoafisica";

            return conn.Query<PessoaFisica>(sql);
        }

        public int InserirPessoaFisica(PessoaFisica _PessoaFisica)
        {
            var conn = _RepositoryBase.conn();
            var val = "";
            var sql = @"insert into tb_pessoafisica (id_PessoaFisica, nome_PessoaFisica, cpf_PessoaFisica) 
                values(@id_PessoaFisica, @nome_PessoaFisica, @cpf_PessoaFisica)";
            
            return conn.Execute(sql, new
            {
                id_PessoaFisica = _PessoaFisica.idPessoaFisica,
                nome_PessoaFisica = _PessoaFisica.nomePessoaFisica,
                cpf_PessoaFisica = _PessoaFisica.cpfPessoaFisica
            });
        }

        public int AtualizarPessoaFisica(PessoaFisica _PessoaFisica, string filtro)
        {
            var conn = _RepositoryBase.conn();
            var sql = @"update tb_pessoafisica set 
                id_PessoaFisica = @id_PessoaFisica, 
                nome_PessoaFisica = @nome_PessoaFisica, 
                cpf_PessoaFisica = @cpf_PessoaFisica 
                where id_PessoaFisica = " + filtro;

            return conn.Execute(sql, new
            {
                 id_PessoaFisica = _PessoaFisica.idPessoaFisica, 
                 nome_PessoaFisica = _PessoaFisica.nomePessoaFisica, 
                 cpf_PessoaFisica = _PessoaFisica.cpfPessoaFisica  
            });
        }

        public int DeletarPessoaFisica(string filtro)
        {
            var conn = _RepositoryBase.conn();

            var sql = "delete from tb_pessoafisica where id_PessoaFisica = " + filtro;
            return conn.Execute(sql); 
        }
    }
}
