using MediatR;
using ApplicationProgram.Domain.Models.Candidates;

namespace ApplicationProgram.Application.Handlers.Candidates.Commands.Create
{
    public class CreateCandidateCommandHandler : IRequestHandler<CreateCandidateCommand, BaseResponse>
    {
        private readonly ICandidateRepository _candidateRepository;

        public CreateCandidateCommandHandler(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public async Task<BaseResponse> Handle(CreateCandidateCommand command, CancellationToken cancellationToken)
        {
            Candidate candidate = new Candidate(
                command.FirstName,
                command.LastName,
                command.Email,
                command.FormId,
                command.Phone,
                command.Nationality,
                command.CurrentResident,
                command.IdNumber,
                command.DateOfBirth,
                command.Gender);

            if (command.CustomQuestionAnswers.Any())
            {
                foreach (var answer in command.CustomQuestionAnswers)
                {
                    string choiceIdList = answer.ChoiceIds != null && answer.ChoiceIds.Any() ? string.Join(", ", answer.ChoiceIds) : null;
                    CustomQuestionAnswer customQuestionAnswer = candidate.AddCustomQuestionAnswer(
                        answer.QuestionId,
                        answer.QuestionType,
                        answer.WrittenAnswer,
                        choiceIdList,
                        answer.YesNoAnswer,
                        answer.DateTimeAnswer);
                }
            }

            await _candidateRepository.Add(candidate);

            return new CreateCandidateCommandResponse(candidate.Id, candidate.FirstName, candidate.LastName);
        }
    }
}
