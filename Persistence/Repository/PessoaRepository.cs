using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Barinbar.API.Domain.Model;
using Barinbar.API.Persistence.Repository;
using Barinbar.API.Persistence.Context;
using Barinbar.API.Domain.Repository;

namespace Barinbar.API.Persistence.Repository
{
    public class PessoaRepository : BaseRepository, IPessoaRepository 
    {
        public PessoaRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Pessoa>> ListAsync()
        {
            return await _context.Pessoa.ToListAsync();
        }

        public async Task AddAsync(Pessoa pessoa)
        {
            await _context.Pessoa.AddAsync(pessoa);
        }
        public async Task<Pessoa> FindByIdAsync(int id)
        {
            return await _context.Pessoa.FindAsync(id);
        }       
        public void Remove(Pessoa pessoa)
        {
            _context.Pessoa.Remove(pessoa);
        }
        public void Update(Pessoa pessoa)
        {
            _context.Pessoa.Update(pessoa);
        }

    }
}