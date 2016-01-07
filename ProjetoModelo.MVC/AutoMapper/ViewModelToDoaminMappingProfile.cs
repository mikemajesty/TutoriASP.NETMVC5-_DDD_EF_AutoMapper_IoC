using AutoMapper;
using ProjetoModel.Domain.Entities;
using ProjetoModelo.MVC.ViewModel;

namespace ProjetoModelo.MVC.AutoMapper
{
    public class ViewModelToDoaminMappingProfile : Profile
    {
        public ViewModelToDoaminMappingProfile() : 
            base(nameof(DomainToViewModelMappingProfile))
        {

        }
        protected override void Configure()
        {
            Mapper.CreateMap<Client, ClientViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
        }
    }
}