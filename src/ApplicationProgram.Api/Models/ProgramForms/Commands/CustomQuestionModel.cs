using ApplicationProgram.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ApplicationProgram.Api.Models.ProgramForms.Commands
{
    public class CustomQuestionModel
    {
        [Required]
        public string Question { get; set; }

        public QuestionTypes QuestionType { get; set; }

        public List<AnswerChoiceModel>? Choices { get; set; }

        public bool? OtherEnabled { get; set; }

        public int? MaxChoice { get; set; }
    }
}
