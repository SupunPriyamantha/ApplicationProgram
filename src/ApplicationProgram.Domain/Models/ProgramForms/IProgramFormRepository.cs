namespace ApplicationProgram.Domain.Models.ProgramForms
{
    public interface IProgramFormRepository
    {
        Task<ProgramForm> Get(int id);

        Task<IEnumerable<ProgramForm>> GetAll();

        Task Add(ProgramForm programForm);

        Task Delete(int id);

        Task Update(ProgramForm programForm);
    }
}
