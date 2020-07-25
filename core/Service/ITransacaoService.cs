using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Service
{
    using core.Domain.Entities;
    using core.Service;

    public interface ITransacaoService
    {
        IEnumerable<Transacao> ConsultaTransacao();
        int InserirTransacao (Transacao _Transacao);
        int AlterarTransacao (Transacao _Transacao, string filtro);
        IEnumerable<Transacao> ConsultaTransacao(string filtro);
        int DeletarTransacao (string filtro);
    }
}
