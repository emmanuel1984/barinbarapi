using System.Collections.Generic;
using System.Threading.Tasks;
using Barinbar.API.Domain.Model;

namespace Barinbar.API.Domain.Repository
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<Pessoa>> ListAsync();

        Task AddAsync(Pessoa pessoa);

        Task<Pessoa> FindByIdAsync(int id);

        void Update(Pessoa pessoa);

        void Remove(Pessoa pessoa);
    }
}