using AutoMapper;

namespace ApplicationProgram.Api.Models.ProgramForms
{
    public class CandidateAutoMapperProfile : Profile
    {
        public CandidateAutoMapperProfile()
        {
            //Commands
            CreateMap<Commands.Create.CreateProgramFormCommand, Application.Handlers.ProgramForms.Commands.Create.CreateProgramFormCommand>();
            CreateMap<Commands.Update.UpdateProgramFormCommand, Application.Handlers.ProgramForms.Commands.Update.UpdateProgramFormCommand>()
                .ForMember(dest => dest.FormId, opts => opts.Ignore());
            CreateMap<Commands.CustomQuestionModel, Application.Handlers.ProgramForms.Commands.CustomQuestionModel>();
            CreateMap<Commands.AnswerChoiceModel, Application.Handlers.ProgramForms.Commands.AnswerChoiceModel>();

            CreateMap<Application.Handlers.ProgramForms.Commands.Create.CreateProgramFormCommandResponse, Commands.Create.CreateProgramFormCommandResponse>()
                .IncludeBase<Application.Handlers.BaseResponse, BaseResponse>();
            CreateMap<Application.Handlers.ProgramForms.Commands.Update.UpdateProgramFormCommandResponse, Commands.Update.UpdateProgramFormCommandResponse>()
                .IncludeBase<Application.Handlers.BaseResponse, BaseResponse>();


            // Queries
            CreateMap<Application.Handlers.ProgramForms.Queries.Details.ProgramFormDetailsQueryResponse, Queries.Details.ProgramFormDetailsQueryResponse>()
                .IncludeBase<Application.Handlers.BaseResponse, BaseResponse>();

            CreateMap<Application.Handlers.ProgramForms.Queries.Details.ProgramFormModel, Queries.Details.ProgramFormModel>();
            CreateMap<Application.Handlers.ProgramForms.Queries.Details.CustomQuestionsModel, Queries.Details.CustomQuestionModel>();
            CreateMap<Application.Handlers.ProgramForms.Queries.Details.AnswerChoiceModel, Queries.Details.AnswerChoiceModel>();
        }
    }
}
