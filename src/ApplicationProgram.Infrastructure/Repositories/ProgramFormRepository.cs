using ApplicationProgram.Domain.Models.ProgramForms;
using Microsoft.EntityFrameworkCore;

namespace ApplicationProgram.Infrastructure.Repositories
{
    public class ProgramFormRepository : IProgramFormRepository
    {
        private readonly AppDbContext _context;

        public ProgramFormRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Add(ProgramForm programForm)
        {
            _context.ProgramForms.Add(programForm);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var programFormToDelete = await _context.ProgramForms.FindAsync(id);

            _context.ProgramForms.Remove(programFormToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<ProgramForm> Get(int id)
        {
            return await GetQueryable().FirstOrDefaultAsync(c => c.Id.Equals(id));
        }

        public async Task<IEnumerable<ProgramForm>> GetAll()
        {
            return await GetQueryable().ToListAsync();
        }

        public async Task Update(ProgramForm programForm)
        {
            _context.Entry(programForm).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        private IQueryable<ProgramForm> GetQueryable()
        {
            return _context.ProgramForms
                .Include(p => p.CustomQuestions).ThenInclude(c => c.Choices)
                .AsSplitQuery();
        }
    }
}
