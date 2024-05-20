using MediatR;
using ApplicationProgram.Domain.Models.ProgramForms;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Commands.Create
{
    public class CreateProgramFormCommandHandler : IRequestHandler<CreateProgramFormCommand, BaseResponse>
    {
        private readonly IProgramFormRepository _programFormRepository;

        public CreateProgramFormCommandHandler(IProgramFormRepository programFormRepository)
        {
            _programFormRepository = programFormRepository;
        }

        public async Task<BaseResponse> Handle(CreateProgramFormCommand command, CancellationToken cancellationToken)
        {
            ProgramForm programForm = new ProgramForm(command.Title, command.Description);

            if (command.CustomQuestions != null && command.CustomQuestions.Any())
            {
                foreach(var question in command.CustomQuestions)
                {
                    CustomQuestion customQuestion = programForm.AddCustomQuestion(
                        question.Question,
                        question.QuestionType,
                        question.OtherEnabled,
                        question.MaxChoice);

                    if (question.Choices != null && question.Choices.Any())
                    {
                        foreach (var choice in question.Choices)
                        {
                            customQuestion.AddAnswerChoice(choice.Choice);
                        }
                    }
                }
            }

            await _programFormRepository.Add(programForm);

            return new CreateProgramFormCommandResponse(programForm.Id, programForm.Title, programForm.Description);
        }
    }
}
