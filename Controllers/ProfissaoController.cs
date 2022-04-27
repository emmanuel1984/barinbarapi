using Barinbar.API.Domain.Model;
using Barinbar.API.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Barinbar.API.Controllers
{
    [Route("/api/[controller]")]
    public class ProfissaoController : ControllerBase
    {
        private readonly IProfissaoService _profissaoService;

        public ProfissaoController(IProfissaoService profissaoService)
        {
            _profissaoService = profissaoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Profissao>> GetAllAsync()
        {
            var profissao = await _profissaoService.ListAsync();
            return profissao;
        }

    }

}