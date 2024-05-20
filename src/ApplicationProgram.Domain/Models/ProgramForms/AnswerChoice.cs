namespace ApplicationProgram.Domain.Models.ProgramForms
{
    public class AnswerChoice
    {
        public AnswerChoice(string choice)
        {
            Choice = choice;
        }

        public int Id { get; set; }

        public string Choice { get; set; }
    }
}
