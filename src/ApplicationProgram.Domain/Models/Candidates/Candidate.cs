using ApplicationProgram.Domain.Enums;

namespace ApplicationProgram.Domain.Models.Candidates
{
    public class Candidate
    {
        private readonly List<CustomQuestionAnswer> _customQuestionAnswers;

        public Candidate(
            string firstName,
            string lastName,
            string email,
            int formId,
            string phone,
            string nationality,
            string currentResident,
            string idNumber,
            DateTime? dateOfBirth,
            string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            FormId = formId;
            Phone = phone;
            Nationality = nationality;
            CurrentResident = currentResident;
            IdNumber = idNumber;
            DateOfBirth = dateOfBirth;
            Gender = gender;

            _customQuestionAnswers = new List<CustomQuestionAnswer>();
        }

        public int Id { get; set; }

        public int FormId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Nationality { get; set; }

        public string CurrentResident { get; set; }

        public string IdNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Gender { get; set; }

        public IReadOnlyCollection<CustomQuestionAnswer> CustomQuestionAnswers => _customQuestionAnswers;

        public CustomQuestionAnswer AddCustomQuestionAnswer(
            int questionId,
            QuestionTypes questionType,
            string writtenAnswer,
            string choiceIdList,
            bool? yesNoAnswer,
            DateTime? dateTimeAnswer)
        {
            var customQuestionAnswer = new CustomQuestionAnswer(
                questionId,
                questionType,
                writtenAnswer,
                choiceIdList,
                yesNoAnswer,
                dateTimeAnswer);

            _customQuestionAnswers.Add(customQuestionAnswer);
            return customQuestionAnswer;
        }
    }
}
