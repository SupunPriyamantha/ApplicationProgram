using MediatR;
using ApplicationProgram.Domain.Models.ProgramForms;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Commands.Update
{
    public class UpdateProgramFormCommandHandler : IRequestHandler<UpdateProgramFormCommand, BaseResponse>
    {
        private readonly IProgramFormRepository _programFormRepository;

        public UpdateProgramFormCommandHandler(IProgramFormRepository programFormRepository)
        {
            _programFormRepository = programFormRepository;
        }

        public async Task<BaseResponse> Handle(UpdateProgramFormCommand command, CancellationToken cancellationToken)
        {
            ProgramForm programForm = await _programFormRepository.Get(command.FormId);

            if (programForm == null)
            {
                return new NotFoundResponse();
            }

            programForm.RemoveCustomQuestion();

            programForm.ChangeTitle(command.Title);
            programForm.ChangeDescription(command.Description);

            if (command.CustomQuestions != null && command.CustomQuestions.Any())
            {
                foreach (var question in command.CustomQuestions)
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

            await _programFormRepository.Update(programForm);

            return new UpdateProgramFormCommandResponse(programForm.Id, programForm.Title, programForm.Description);
        }
    }
}
