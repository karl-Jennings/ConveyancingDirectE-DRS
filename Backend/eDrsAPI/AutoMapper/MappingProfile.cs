using AutoMapper; 
using eDrsDB.Models;
using eDrsManagers.ViewModels; 

namespace eDrsAPI.AutoMapper
{
    public class MappingProfile : Profile
    {
        //Mapping the related models to their view models
        public MappingProfile()
        {
            CreateMap<ApplicationForm, ApplicationFormViewModel>().ReverseMap();
            CreateMap<DocumentReference, DocumentReferenceViewModel>().ReverseMap();
            CreateMap<TitleNumber, TitleNumberViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
        }

    }
}
