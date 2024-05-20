using ApplicationProgram.Domain.Enums;

namespace ApplicationProgram.Domain.Models.Candidates
{
    public class CustomQuestionAnswer
    {
        public CustomQuestionAnswer(
            int questionId,
            QuestionTypes questionType,
            string writtenAnswer,
            string choiceIdList,
            bool? yesNoAnswer,
            DateTime? dateTimeAnswer)
        {
            QuestionId = questionId;
            QuestionType = questionType;
            WrittenAnswer = writtenAnswer;
            ChoiceIdList = choiceIdList;
            YesNoAnswer = yesNoAnswer;
            DateTimeAnswer = dateTimeAnswer;
        }

        public int Id { get; set; }

        public int QuestionId { get; set; }

        public QuestionTypes QuestionType { get; set; }

        public string WrittenAnswer { get; set; }

        public string ChoiceIdList { get; set; }

        public bool? YesNoAnswer { get; set; }

        public DateTime? DateTimeAnswer { get; set; }
    }
}
