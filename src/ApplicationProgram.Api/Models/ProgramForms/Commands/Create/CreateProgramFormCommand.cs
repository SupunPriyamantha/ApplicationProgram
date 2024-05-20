using System.ComponentModel.DataAnnotations;

namespace ApplicationProgram.Api.Models.ProgramForms.Commands.Create
{
    public class CreateProgramFormCommand
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public List<CustomQuestionModel>? CustomQuestions { get; set; }
    }
}
