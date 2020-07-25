using System.Collections.Generic;

namespace core.Service
{
    using System;
    using core.Domain.Entities;
    using core.Domain.Interfaces;
    using core.Service;

    public class PessoaJuridicaService : IPessoaJuridicaService
    {
        private readonly IPessoaJuridicaRepository _PessoaJuridicaRepository;

        public PessoaJuridicaService(IPessoaJuridicaRepository PessoaJuridicaRepository)
        {
            _PessoaJuridicaRepository = PessoaJuridicaRepository;
        }

        public int AlterarPessoaJuridica(PessoaJuridica _PessoaJuridica, string filtro)
        {
            return _PessoaJuridicaRepository.AtualizarPessoaJuridica(_PessoaJuridica, filtro);
        }

        public IEnumerable<PessoaJuridica> ConsultaPessoaJuridica()
        {
            return _PessoaJuridicaRepository.ConsultaPessoaJuridica();
        }

        public IEnumerable<PessoaJuridica> ConsultaPessoaJuridica(string filtro)
        {
            return _PessoaJuridicaRepository.ConsultaPessoaJuridica(filtro);
        }

        public int DeletarPessoaJuridica(string filtro)
        {
            return _PessoaJuridicaRepository.DeletarPessoaJuridica(filtro);
        }

        public int InserirPessoaJuridica(PessoaJuridica _PessoaJuridica)
        {
            return _PessoaJuridicaRepository.InserirPessoaJuridica(_PessoaJuridica);
        }
    }
}
