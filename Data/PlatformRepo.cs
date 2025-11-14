using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }

        public Task createPlatform(Platform newPlatform)
        {
          
            if (newPlatform == null)
                throw new ArgumentNullException(nameof(newPlatform));
            

            _context.Platforms.AddAsync(newPlatform);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Platform>> getAllPlatforms()
        {
           return await _context.Platforms.AsNoTracking().ToListAsync();       
        }

        public Task<Platform> getPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefaultAsync(p => p.Id == id)!;
        }

        public Task<Platform> getPlatformByIdAsNoTracking(int id)
        {
            return _context.Platforms.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id)!;
        }

        public async Task<bool> saveChanges()
        {
          return await _context.SaveChangesAsync()>0;
        }
    }
}