using ProjetoCadastro.Application.Interfaces;
    using ProjetoCadastro.Domain.Entities;
    using ProjetoCadastro.Domain.Interfaces.Service;

    namespace ProjetoCadastro.Application.Services
{
  public  class PessoaAppService : AppServiceBase<Pessoa> , IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;

        public PessoaAppService(IPessoaService pessoaService) : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public bool CheckRegistration(string Email)
        {
          return  _pessoaService.CheckRegistration(Email);
        }
    }
}
