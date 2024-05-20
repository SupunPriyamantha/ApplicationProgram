namespace ApplicationProgram.Api.Models.Candidates.Commands.Create
{
    public class CreateCandidateCommandResponse : BaseResponse
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
