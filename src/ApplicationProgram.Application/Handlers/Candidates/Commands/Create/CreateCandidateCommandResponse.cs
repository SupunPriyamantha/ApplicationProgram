using Microsoft.AspNetCore.Http;

namespace ApplicationProgram.Application.Handlers.Candidates.Commands.Create
{
    public class CreateCandidateCommandResponse : BaseResponse
    {
        public CreateCandidateCommandResponse(
            int id,
            string firstName,
            string lastName)
            : base(StatusCodes.Status200OK)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
