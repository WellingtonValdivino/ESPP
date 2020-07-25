using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Service
{
    using core.Domain.Entities;
    using core.Service;

    public interface IPessoaFisicaService
    {
        IEnumerable<PessoaFisica> ConsultaPessoaFisica();
        int InserirPessoaFisica (PessoaFisica _PessoaFisica);
        int AlterarPessoaFisica (PessoaFisica _PessoaFisica, string filtro);
        IEnumerable<PessoaFisica> ConsultaPessoaFisica(string filtro);
        int DeletarPessoaFisica (string filtro);
    }
}
