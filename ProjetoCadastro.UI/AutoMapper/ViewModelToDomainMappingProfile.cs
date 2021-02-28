using AutoMapper;
using ProjetoCadastro.Domain.Entities;
using ProjetoCadastro.UI.ViewModels;

namespace ProjetoCadastro.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Pessoa, PessoaViewModel>();
        }
    }
}