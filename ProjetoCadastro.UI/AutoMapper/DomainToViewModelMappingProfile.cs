using AutoMapper;
using ProjetoCadastro.Domain.Entities;
using ProjetoCadastro.UI.ViewModels;

namespace ProjetoCadastro.UI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
          public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
          

          protected override void Configure()
          {
              Mapper.CreateMap<PessoaViewModel, Pessoa>();
          }
    }
}