using ProjetoCadastro.Domain.Entities;

namespace ProjetoCadastro.Domain.Interfaces.Repositories
{
    public interface IPessoaRepository : IRepositoryBase<Pessoa>
    {
        bool CheckRegistration(string Email);
    }
}
