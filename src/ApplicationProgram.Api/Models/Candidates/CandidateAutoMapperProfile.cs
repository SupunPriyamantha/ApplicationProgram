using AutoMapper;

namespace ApplicationProgram.Api.Models.Candidates
{
    public class CandidateAutoMapperProfile : Profile
    {
        public CandidateAutoMapperProfile()
        {
            //Commands
            CreateMap<Commands.Create.CreateCandidateCommand, Application.Handlers.Candidates.Commands.Create.CreateCandidateCommand>();
            CreateMap<Commands.Create.CustomQuestionAnswerModel, Application.Handlers.Candidates.Commands.Create.CustomQuestionAnswerModel>();

            CreateMap<Application.Handlers.Candidates.Commands.Create.CreateCandidateCommandResponse, Commands.Create.CreateCandidateCommandResponse>()
                .IncludeBase<Application.Handlers.BaseResponse, BaseResponse>();
        }
    }
}
