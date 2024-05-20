using System.ComponentModel.DataAnnotations;

namespace ApplicationProgram.Api.Models.Candidates.Commands.Create
{
    public class CreateCandidateCommand
    {
        [Required]
        public int FormId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string? Phone { get; set; }

        public string? Nationality { get; set; }

        public string? CurrentResident { get; set; }

        public string? IdNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Gender { get; set; }

        public List<CustomQuestionAnswerModel> CustomQuestionAnswers { get; set; }
    }
}
