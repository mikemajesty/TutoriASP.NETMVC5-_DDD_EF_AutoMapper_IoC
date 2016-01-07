using AutoMapper;

namespace ProjetoModelo.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize((e) =>
            {
                e.AddProfile<DomainToViewModelMappingProfile>();
                e.AddProfile<ViewModelToDoaminMappingProfile>();
            });
        }
    }
}