using MediatR;

namespace ApplicationProgram.Application.Handlers.Candidates.Commands.Create
{
    public class CreateCandidateCommand : IRequest<BaseResponse>
    {
        public int FormId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Nationality { get; set; }

        public string CurrentResident { get; set; }

        public string IdNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Gender { get; set; }

        public List<CustomQuestionAnswerModel> CustomQuestionAnswers { get; set; }
    }
}
