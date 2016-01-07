using AutoMapper;
using ProjetoModel.Domain.Entities;
using ProjetoModelo.MVC.ViewModel;

namespace ProjetoModelo.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() : 
            base(nameof(ViewModelToDoaminMappingProfile))
        {

        }
        protected override void Configure()
        {
            Mapper.CreateMap<ClientViewModel, Client>();
            Mapper.CreateMap<ProductViewModel, Product>();
        }
      
    }
}