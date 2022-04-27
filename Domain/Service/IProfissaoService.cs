using Barinbar.API.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Barinbar.API.Domain.Service
{
    public interface IProfissaoService
    {
        Task<IEnumerable<Profissao>> ListAsync();
    }
}