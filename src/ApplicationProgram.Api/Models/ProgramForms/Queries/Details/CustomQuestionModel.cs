using ApplicationProgram.Domain.Enums;

namespace ApplicationProgram.Api.Models.ProgramForms.Queries.Details
{
    public class CustomQuestionModel
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public QuestionTypes QuestionType { get; set; }

        public List<AnswerChoiceModel> Choices { get; set; }

        public bool? OtherEnabled { get; set; }

        public int? MaxChoice { get; set; }
    }
}
