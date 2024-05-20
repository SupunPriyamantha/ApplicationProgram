using Microsoft.AspNetCore.Http;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Commands.Create
{
    public class CreateProgramFormCommandResponse : BaseResponse
    {
        public CreateProgramFormCommandResponse(
            int formId,
            string title,
            string description)
            : base(StatusCodes.Status200OK)
        {
            FormId = formId;
            Title = title;
            Description = description;
        }

        public int FormId { get; }

        public string Title { get; }

        public string Description { get; }
    }
}
