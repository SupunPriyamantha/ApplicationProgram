using Microsoft.AspNetCore.Http;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Commands.Update
{
    public class UpdateProgramFormCommandResponse : BaseResponse
    {
        public UpdateProgramFormCommandResponse(
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
