using MediatR;
using ApplicationProgram.Domain.Models.ProgramForms;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Queries.Details
{
    public class ProgramFormDetailsQueryHandler : IRequestHandler<ProgramFormDetailsQuery, BaseResponse>
    {
        private readonly IProgramFormRepository _programFormRepository;

        public ProgramFormDetailsQueryHandler(IProgramFormRepository programFormRepository)
        {
            _programFormRepository = programFormRepository;
        }
        public async Task<BaseResponse> Handle(ProgramFormDetailsQuery query, CancellationToken cancellationToken)
        {
            ProgramForm programForm = await _programFormRepository.Get(query.Id);

            if (programForm == null)
            {
                return new NotFoundResponse();
            }

            return new ProgramFormDetailsQueryResponse(new ProgramFormModel(
                programForm.Id,
                programForm.Title,
                programForm.Description,
                programForm.CustomQuestions.Select(cq => new CustomQuestionsModel(
                    cq.Id,
                    programForm.Id,
                    cq.Question,
                    cq.QuestionType,
                    cq.Choices.Select(c => new AnswerChoiceModel(
                        c.Id,
                        cq.Id,
                        c.Choice)),
                    cq.OtherEnabled,
                    cq.MaxChoice))));
        }
    }
}
