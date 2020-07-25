using System.Collections.Generic;

namespace core.Service
{
    using System;
    using core.Domain.Entities;
    using core.Domain.Interfaces;
    using core.Service;

    public class PessoaFisicaService : IPessoaFisicaService
    {
        private readonly IPessoaFisicaRepository _PessoaFisicaRepository;

        public PessoaFisicaService(IPessoaFisicaRepository PessoaFisicaRepository)
        {
            _PessoaFisicaRepository = PessoaFisicaRepository;
        }

        public int AlterarPessoaFisica(PessoaFisica _PessoaFisica, string filtro)
        {
            return _PessoaFisicaRepository.AtualizarPessoaFisica(_PessoaFisica, filtro);
        }

        public IEnumerable<PessoaFisica> ConsultaPessoaFisica()
        {
            return _PessoaFisicaRepository.ConsultaPessoaFisica();
        }

        public IEnumerable<PessoaFisica> ConsultaPessoaFisica(string filtro)
        {
            return _PessoaFisicaRepository.ConsultaPessoaFisica(filtro);
        }

        public int DeletarPessoaFisica(string filtro)
        {
            return _PessoaFisicaRepository.DeletarPessoaFisica(filtro);
        }

        public int InserirPessoaFisica(PessoaFisica _PessoaFisica)
        {
            return _PessoaFisicaRepository.InserirPessoaFisica(_PessoaFisica);
        }
    }
}
