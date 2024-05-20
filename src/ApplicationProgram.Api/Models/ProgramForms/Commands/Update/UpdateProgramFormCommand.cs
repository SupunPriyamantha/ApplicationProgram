using System.ComponentModel.DataAnnotations;

namespace ApplicationProgram.Api.Models.ProgramForms.Commands.Update
{
    public class UpdateProgramFormCommand
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public List<CustomQuestionModel>? CustomQuestions { get; set; }
    }
}
