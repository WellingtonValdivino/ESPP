namespace core.Domain.Interfaces
{
    using core.Domain.Entities;
    using core.Domain;
    using System.Collections.Generic;

    public interface IPessoaJuridicaRepository
    {
        IEnumerable<PessoaJuridica> ConsultaPessoaJuridica();

        int InserirPessoaJuridica(PessoaJuridica _PessoaJuridica);

        int AtualizarPessoaJuridica(PessoaJuridica _PessoaJuridica, string filtro);

        IEnumerable<PessoaJuridica> ConsultaPessoaJuridica(string filtro);

        int DeletarPessoaJuridica(string filtro);
    }
}
