using Accredit.Shared.Entities;
using Accredit.Ui.Models;
using AutoMapper;

namespace Accredit.Ui.Mapping
{
    public class HumanResourceMappingProfile : Profile
    {
        public HumanResourceMappingProfile()
        {
            CreateMap<HumanResource, HumanResourceViewModel>()
                .ForMember(dest =>
                    dest.Status, opt => opt.MapFrom(src => src.HumanResourceStatus.Name));
        }
    }
}
