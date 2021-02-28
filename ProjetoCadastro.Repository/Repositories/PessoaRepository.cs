using System.Linq;
using ProjetoCadastro.Domain.Entities;
using ProjetoCadastro.Domain.Interfaces.Repositories;
using ProjetoCadastro.Repository.Contexto;

namespace ProjetoCadastro.Repository.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        private ProjetoCadastroContext db = new ProjetoCadastroContext();

        public bool CheckRegistration(string Email)
        {
            bool Result = false;
            if (db.Set<Pessoa>().Where(l => l.Email.Contains(Email)).Count() > 0)
            {
                Result = true;
            }
            return Result;
        }
    }
}