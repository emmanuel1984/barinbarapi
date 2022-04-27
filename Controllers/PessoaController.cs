using Barinbar.API.Domain.Model;
using Barinbar.API.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Barinbar.API.Controllers
{
    [Route("/api/[controller]")]

    public class PessoaController : Controller
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public async Task<IEnumerable<Pessoa>> GetAllAsync()
        {
            var pessoa = await _pessoaService.ListAsync();
            return pessoa;
        }

    }

}