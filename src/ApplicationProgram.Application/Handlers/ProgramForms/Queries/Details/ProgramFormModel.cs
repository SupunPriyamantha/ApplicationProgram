namespace ApplicationProgram.Application.Handlers.ProgramForms.Queries.Details
{
    public class ProgramFormModel
    {
        public ProgramFormModel(
            int id,
            string title,
            string description,
            IEnumerable<CustomQuestionsModel> customQuestions)
        {
            Id = id;
            Title = title;
            Description = description;
            CustomQuestions = customQuestions;
        }

        public int Id { get; }

        public string Title { get; }

        public string Description { get; }

        public IEnumerable<CustomQuestionsModel> CustomQuestions { get; }
    }
}
