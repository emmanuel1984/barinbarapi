using System.Collections.Generic;
using System.Threading.Tasks;
using Barinbar.API.Domain.Model;
using Barinbar.API.Domain.Service;
using Barinbar.API.Domain.Repository;

namespace Barinbar.API.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public async Task<IEnumerable<Pessoa>> ListAsync()
        {
            return await _pessoaRepository.ListAsync();
        }
    }
}