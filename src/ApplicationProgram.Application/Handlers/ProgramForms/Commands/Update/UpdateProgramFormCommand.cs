using MediatR;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Commands.Update
{
    public class UpdateProgramFormCommand : IRequest<BaseResponse>
    {
        public int FormId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<CustomQuestionModel> CustomQuestions { get; set; }
    }
}
