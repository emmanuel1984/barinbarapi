using Barinbar.API.Persistence.Context;

namespace Barinbar.API.Persistence.Repository
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }

}