namespace ApplicationProgram.Api.Models.ProgramForms.Commands.Update
{
    public class UpdateProgramFormCommandResponse : BaseResponse
    {
        public int FormId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
