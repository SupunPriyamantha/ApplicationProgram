using ApplicationProgram.Domain.Enums;

namespace ApplicationProgram.Api.Models.Candidates.Commands.Create
{
    public class CustomQuestionAnswerModel
    {
        public int QuestionId { get; set; }

        public QuestionTypes QuestionType { get; set; }

        public string? WrittenAnswer { get; set; }

        public List<int>? ChoiceIds { get; set; }

        public bool? YesNoAnswer { get; set; }

        public DateTime? DateTimeAnswer { get; set; }
    }
}
