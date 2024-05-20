namespace ApplicationProgram.Api.Models.ProgramForms.Queries.Details
{
    public class ProgramFormModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<CustomQuestionModel> CustomQuestions { get; set; }
    }
}
