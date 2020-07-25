using System.Collections.Generic;

namespace core.Infra.Repository
{
    using System;
    using Dapper;
    using core.Domain;    
    using core.Domain.Entities;
    using core.Domain.Interfaces;
    using core.Infra.Repository;

    public class PessoaJuridicaRepository : IPessoaJuridicaRepository
    {
        private readonly IRepositoryBase _RepositoryBase;

        public PessoaJuridicaRepository(IRepositoryBase Repository)
        {
            _RepositoryBase = Repository;
        }

        public IEnumerable<PessoaJuridica> ConsultaPessoaJuridica(string filtro)
        {
            var conn = _RepositoryBase.conn();
            var sql = @"select  
                id_pessoajuridica AS idPessoaJuridica, 
                razaoSocial_pessoajuridica AS razaoSocialPessoaJuridica, 
                nomeFantasia_pessoajuridica AS nomeFantasiaPessoaJuridica, 
                cnpj_pessoajuridica AS cnpjPessoaJuridica 
                from tb_pessoajuridica where id_pessoajuridica = " + filtro;

            return conn.Query<PessoaJuridica>(sql);
        }

        public IEnumerable<PessoaJuridica> ConsultaPessoaJuridica()
        {
            var conn = _RepositoryBase.conn();

            var sql = @"select  
                id_pessoajuridica AS idPessoaJuridica, 
                razaoSocial_pessoajuridica AS razaoSocialPessoaJuridica, 
                nomeFantasia_pessoajuridica AS nomeFantasiaPessoaJuridica, 
                cnpj_pessoajuridica AS cnpjPessoaJuridica 
                from tb_pessoajuridica";

            return conn.Query<PessoaJuridica>(sql);
        }

        public int InserirPessoaJuridica(PessoaJuridica _PessoaJuridica)
        {
            var conn = _RepositoryBase.conn();
            var val = "";
            var sql = @"insert into tb_pessoajuridica (id_pessoajuridica, razaoSocial_pessoajuridica, nomeFantasia_pessoajuridica, cnpj_pessoajuridica) 
                    values(@id_pessoajuridica, @razaoSocial_pessoajuridica, @nomeFantasia_pessoajuridica, @cnpj_pessoajuridica)";
            
            return conn.Execute(sql, new
            {
                id_pessoajuridica = _PessoaJuridica.idPessoaJuridica,
                razaoSocial_pessoajuridica = _PessoaJuridica.razaoSocialPessoaJuridica,
                nomeFantasia_pessoajuridica = _PessoaJuridica.nomeFantasiaPessoaJuridica,
                cnpj_pessoajuridica = _PessoaJuridica.cnpjPessoaJuridica
            });
        }

        public int AtualizarPessoaJuridica(PessoaJuridica _PessoaJuridica, string filtro)
        {
            var conn = _RepositoryBase.conn();
            var sql = @"update tb_pessoajuridica set 
                id_pessoajuridica = @id_pessoajuridica, 
                razaoSocial_pessoajuridica = @razaoSocial_pessoajuridica, 
                nomeFantasia_pessoajuridica = @nomeFantasia_pessoajuridica, 
                cnpj_pessoajuridica = @cnpj_pessoajuridica 
                where id_pessoajuridica = " + filtro;

            return conn.Execute(sql, new
            {
                 id_pessoajuridica = _PessoaJuridica.idPessoaJuridica, 
                 razaoSocial_pessoajuridica = _PessoaJuridica.razaoSocialPessoaJuridica, 
                 nomeFantasia_pessoajuridica = _PessoaJuridica.nomeFantasiaPessoaJuridica, 
                 cnpj_pessoajuridica = _PessoaJuridica.cnpjPessoaJuridica  
            });
        }


        public int DeletarPessoaJuridica(string filtro)
        {
            var conn = _RepositoryBase.conn();

            var sql = "delete from tb_pessoajuridica where id_pessoajuridica = " + filtro;
            return conn.Execute(sql); 
        }
    }
}
