using ApplicationProgram.Domain.Enums;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Commands
{
    public class CustomQuestionModel
    {
        public string Question { get; set; }

        public QuestionTypes QuestionType { get; set; }

        public List<AnswerChoiceModel> Choices { get; set; }

        public bool? OtherEnabled { get; set; }

        public int? MaxChoice { get; set; }
    }
}
