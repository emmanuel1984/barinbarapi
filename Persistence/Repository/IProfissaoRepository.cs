using System.Collections.Generic;
using System.Threading.Tasks;
using Barinbar.API.Domain.Model;

namespace Barinbar.API.Domain.Repository
{
    public interface IProfissaoRepository
    {
        Task<IEnumerable<Profissao>> ListAsync();

        Task AddAsync(Profissao profissao);

        Task<Profissao> FindByIdAsync(int id);

        void Update(Profissao profissao);

        void Remove(Profissao profissao);
    }
}