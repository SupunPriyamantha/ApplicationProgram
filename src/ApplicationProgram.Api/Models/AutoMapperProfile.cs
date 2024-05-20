using AutoMapper;

namespace ApplicationProgram.Api.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Application.Handlers.BaseResponse, BaseResponse>()
                .Include<Application.Handlers.NotFoundResponse, NotFoundResponse>();

            CreateMap<Application.Handlers.NotFoundResponse, NotFoundResponse>();
        }
    }
}
