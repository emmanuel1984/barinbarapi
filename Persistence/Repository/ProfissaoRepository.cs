using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Barinbar.API.Domain.Model;
using Barinbar.API.Persistence.Repository;
using Barinbar.API.Persistence.Context;
using Barinbar.API.Domain.Repository;

namespace Barinbar.API.Persistence.Repository
{
    public class ProfissaoRepository : BaseRepository, IProfissaoRepository 
    {
        public ProfissaoRepository (AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Profissao>> ListAsync()
        {
            return await _context.Profissao.ToListAsync();
        }

        public async Task AddAsync(Profissao profissao)
        {
            await _context.Profissao.AddAsync(profissao);
        }
        public async Task<Profissao> FindByIdAsync(int id)
        {
            return await _context.Profissao.FindAsync(id);
        }       
        public void Remove(Profissao profissao)
        {
            _context.Profissao.Remove(profissao);
        }
        public void Update(Profissao profissao)
        {
            _context.Profissao.Update(profissao);
        }   
    }
}