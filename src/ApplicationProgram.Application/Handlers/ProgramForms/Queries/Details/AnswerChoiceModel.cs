namespace ApplicationProgram.Application.Handlers.ProgramForms.Queries.Details
{
    public class AnswerChoiceModel
    {
        public AnswerChoiceModel(
            int id,
            int questionId,
            string choice)
        {
            Id = id;
            QuestionId = questionId;
            Choice = choice;
        }

        public int Id { get; }

        public int QuestionId { get; }

        public string Choice { get; }
    }
}
