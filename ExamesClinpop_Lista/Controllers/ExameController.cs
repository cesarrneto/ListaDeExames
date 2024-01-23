using ExamesClinpop_Lista.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExamesClinpop_Lista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExameController : ControllerBase
    {
        public class ProductController : ControllerBase
        {
            private readonly IExameService _exameService;

            public ProductController(IExameService exameService)
            {
                _exameService = exameService;
            }

            [HttpGet]
            public async Task GetExames()
            {
                await _exameService.GetExames();
            }

            [HttpGet("{id}")]
            public async Task GetExameById(int id)
            {
                await _exameService.GetExameById(id);
            }

            [HttpPost]
            public async Task CreateExame(Exame exame)
            {
                await _exameService.CreateExame(exame);
            }

            [HttpPut("{id}")]
            public async Task UpdateExame(int id, Exame exame)
            {
                await _exameService.UpdateExame(id, exame);
            }

            [HttpDelete("{id}")]
            public async Task DeleteExame(int id)
            {
                await _exameService.DeleteExame(id);
            }
        }
    }
}
