using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Service
{
    using core.Domain.Entities;
    using core.Service;

    public interface IPessoaJuridicaService
    {
        IEnumerable<PessoaJuridica> ConsultaPessoaJuridica();
        int InserirPessoaJuridica (PessoaJuridica _PessoaJuridica);
        int AlterarPessoaJuridica (PessoaJuridica _PessoaJuridica, string filtro);
        IEnumerable<PessoaJuridica> ConsultaPessoaJuridica(string filtro);
        int DeletarPessoaJuridica (string filtro);
    }
}
