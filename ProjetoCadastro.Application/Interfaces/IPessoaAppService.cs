using ProjetoCadastro.Domain.Entities;

namespace ProjetoCadastro.Application.Interfaces
{
    public interface IPessoaAppService : IAppServiceBase<Pessoa>
    {
        bool CheckRegistration(string Email);
    }
}
