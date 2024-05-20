using ApplicationProgram.Domain.Enums;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Queries.Details
{
    public class CustomQuestionsModel
    {
        public CustomQuestionsModel(
            int id,
            int formId,
            string question,
            QuestionTypes questionType,
            IEnumerable<AnswerChoiceModel> choices,
            bool? otherEnabled,
            int? maxChoice)
        {
            Id = id;
            FormId = formId;
            Question = question;
            QuestionType = questionType;
            Choices = choices;
            OtherEnabled = otherEnabled;
            MaxChoice = maxChoice;
        }

        public int Id { get; }

        public int FormId { get; }

        public string Question { get; }

        public QuestionTypes QuestionType { get; }

        public IEnumerable<AnswerChoiceModel> Choices { get; }

        public bool? OtherEnabled { get; }

        public int? MaxChoice { get; }
    }
}
