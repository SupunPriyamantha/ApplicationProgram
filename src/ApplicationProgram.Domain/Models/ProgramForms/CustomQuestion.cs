using ApplicationProgram.Domain.Enums;

namespace ApplicationProgram.Domain.Models.ProgramForms
{
    public class CustomQuestion
    {
        private readonly List<AnswerChoice> _choices;

        public CustomQuestion(
            string question,
            QuestionTypes questionType,
            bool? otherEnabled,
            int? maxChoice)
        {
            Question = question;
            QuestionType = questionType;
            OtherEnabled = otherEnabled;
            MaxChoice = maxChoice;

            _choices = new List<AnswerChoice>();
        }


        public int Id { get; set; }

        public string Question { get; set; }

        public QuestionTypes QuestionType { get; set; }

        public IReadOnlyCollection<AnswerChoice> Choices => _choices;

        public bool? OtherEnabled { get; set; }

        public int? MaxChoice { get; set; }

        public AnswerChoice AddAnswerChoice(string choice)
        {
            var answerChoice = new AnswerChoice(choice);

            _choices.Add(answerChoice);
            return answerChoice;
        }
    }
}
