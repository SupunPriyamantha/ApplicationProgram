namespace ApplicationProgram.Domain.Models.Candidates
{
    public interface ICandidateRepository
    {
        Task<Candidate> Get(int id);

        Task<IEnumerable<Candidate>> GetAll();

        Task Add(Candidate candidate);

        Task Delete(int id);

        Task Update(Candidate candidate);
    }
}
