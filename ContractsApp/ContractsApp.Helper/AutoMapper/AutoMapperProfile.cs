using AutoMapper;
using ContractsApp.Dto.DtoResponse;
using ContractsApp.Model;


namespace ContractsApp.Helper.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Contract, ContractDtoRE>()
          .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Contractitems.Select(ci => ci.Item)));

            CreateMap<Item, ItemDtoRE>();
        }

    }
}
