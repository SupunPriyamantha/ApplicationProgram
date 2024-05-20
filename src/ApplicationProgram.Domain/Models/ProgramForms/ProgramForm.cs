using ApplicationProgram.Domain.Enums;

namespace ApplicationProgram.Domain.Models.ProgramForms
{
    public class ProgramForm
    {
        private readonly List<CustomQuestion> _customQuestions;

        public ProgramForm(
            string title,
            string description)
        {
            Title = title;
            Description = description;

            _customQuestions = new List<CustomQuestion>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IReadOnlyCollection<CustomQuestion> CustomQuestions => _customQuestions;

        public ProgramForm ChangeTitle(string title)
        {
            Title = title;
            return this;
        }

        public ProgramForm ChangeDescription(string description)
        {
            Description = description;
            return this;
        }

        public CustomQuestion AddCustomQuestion(
            string question,
            QuestionTypes questionType,
            bool? otherEnabled,
            int? maxChoice)
        {
            var customQuestion = new CustomQuestion(
                question,
                questionType,
                otherEnabled,
                maxChoice);

            _customQuestions.Add(customQuestion);
            return customQuestion;
        }

        public ProgramForm RemoveCustomQuestion()
        {
            _customQuestions.Clear();
            return this;
        }
    }
}
