namespace core.Domain.Interfaces
{
    using core.Domain.Entities;
    using core.Domain;
    using System.Collections.Generic;

    public interface IPessoaFisicaRepository
    {
        IEnumerable<PessoaFisica> ConsultaPessoaFisica();

        int InserirPessoaFisica(PessoaFisica _PessoaFisica);

        int AtualizarPessoaFisica(PessoaFisica _PessoaFisica, string filtro);

        IEnumerable<PessoaFisica> ConsultaPessoaFisica(string filtro);

        int DeletarPessoaFisica(string filtro);
    }
}
