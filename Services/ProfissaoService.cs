using System.Collections.Generic;
using System.Threading.Tasks;
using Barinbar.API.Domain.Model;
using Barinbar.API.Domain.Service;
using Barinbar.API.Domain.Repository;

namespace Barinbar.API.Services
{
    public class ProfissaoService : IProfissaoService
    {
        private readonly IProfissaoRepository _profissaoRepository;

        public ProfissaoService(IProfissaoRepository profissaoRepository)
        {
            _profissaoRepository = profissaoRepository;
        }

        public async Task<IEnumerable<Profissao>> ListAsync()
        {
            return await _profissaoRepository.ListAsync();
        }
    }
}