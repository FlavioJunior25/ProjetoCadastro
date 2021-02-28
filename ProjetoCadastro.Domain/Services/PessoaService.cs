using ProjetoCadastro.Domain.Entities;
using ProjetoCadastro.Domain.Interfaces.Repositories;
using ProjetoCadastro.Domain.Interfaces.Service;

namespace ProjetoCadastro.Domain.Services
{
   public class PessoaService : ServiceBase<Pessoa> , IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository) : base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public bool CheckRegistration(string Email)
        {
            return _pessoaRepository.CheckRegistration(Email);
        }
    }
}
