using Microsoft.AspNetCore.Mvc;
using Fiap.GestaoFinanca.Application.DTOs;
using Fiap.GestaoFinanca.Domain.Entities;
using Fiap.GestaoFinanca.Application.Mappings;
namespace Fiap.GestaoFinanca.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DespesasController : ControllerBase
    {
        [HttpPost]
        public IActionResult Criar([FromBody] DespesaRequest request)
        {
            var despesa = new Despesa(
                request.Descricao,
                request.Valor,
                request.Data,
                request.Categoria,
                request.FormaPagamento
            );

            var response = despesa.ToResponse();

            return Created($"api/despesas/{response.Id}", response);
        }
    }
}
