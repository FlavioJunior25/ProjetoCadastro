using System.Data.Entity.ModelConfiguration;
using ProjetoCadastro.Domain.Entities;

namespace ProjetoCadastro.Repository.EntityConfig
{
    class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Email).IsRequired().HasMaxLength(100);
        }
    }
}
