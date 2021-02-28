using ProjetoCadastro.Domain.Entities;

namespace ProjetoCadastro.Domain.Interfaces.Service
{
   public interface IPessoaService : IServiceBase<Pessoa>
   {
       bool CheckRegistration(string Email);
   }
}
