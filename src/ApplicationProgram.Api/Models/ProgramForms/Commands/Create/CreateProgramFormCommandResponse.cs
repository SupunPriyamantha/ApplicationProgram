namespace ApplicationProgram.Api.Models.ProgramForms.Commands.Create
{
    public class CreateProgramFormCommandResponse : BaseResponse
    {
        public int FormId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
