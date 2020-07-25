using System.Collections.Generic;

namespace core.Service
{
    using System;
    using core.Domain.Entities;
    using core.Domain.Interfaces;
    using core.Service;

    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _TransacaoRepository;

        public TransacaoService(ITransacaoRepository TransacaoRepository)
        {
            _TransacaoRepository = TransacaoRepository;
        }

        public int AlterarTransacao(Transacao _Transacao, string filtro)
        {
            return _TransacaoRepository.AtualizarTransacao(_Transacao, filtro);
        }

        public IEnumerable<Transacao> ConsultaTransacao()
        {
            return _TransacaoRepository.ConsultaTransacao();
        }

        public IEnumerable<Transacao> ConsultaTransacao(string filtro)
        {
            return _TransacaoRepository.ConsultaTransacao(filtro);
        }

        public int DeletarTransacao(string filtro)
        {
            return _TransacaoRepository.DeletarTransacao(filtro);
        }

        public int InserirTransacao(Transacao _Transacao)
        {
            return _TransacaoRepository.InserirTransacao(_Transacao);
        }
    }
}
