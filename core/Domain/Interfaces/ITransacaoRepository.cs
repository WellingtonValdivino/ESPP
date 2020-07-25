namespace core.Domain.Interfaces
{
    using core.Domain.Entities;
    using core.Domain;
    using System.Collections.Generic;

    public interface ITransacaoRepository
    {
        IEnumerable<Transacao> ConsultaTransacao();

        int InserirTransacao(Transacao _Transacao);

        int AtualizarTransacao(Transacao _Transacao, string filtro);

        IEnumerable<Transacao> ConsultaTransacao(string filtro);

        int DeletarTransacao(string filtro);
    }
}
