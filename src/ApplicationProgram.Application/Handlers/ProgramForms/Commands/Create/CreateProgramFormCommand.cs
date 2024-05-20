using MediatR;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Commands.Create
{
    public class CreateProgramFormCommand : IRequest<BaseResponse>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public List<CustomQuestionModel> CustomQuestions { get; set; }
    }
}
