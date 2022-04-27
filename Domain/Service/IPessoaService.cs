using Barinbar.API.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Barinbar.API.Domain.Service
{
    public interface IPessoaService
    {
        Task<IEnumerable<Pessoa>> ListAsync();
    }
}