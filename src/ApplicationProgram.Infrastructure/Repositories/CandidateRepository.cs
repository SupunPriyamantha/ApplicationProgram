using ApplicationProgram.Domain.Models.Candidates;

namespace ApplicationProgram.Infrastructure.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly AppDbContext _context;

        public CandidateRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Add(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Candidate> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Candidate>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Candidate candidate)
        {
            throw new NotImplementedException();
        }
    }
}
