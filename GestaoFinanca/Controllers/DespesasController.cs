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

        [HttpGet("exemplo")]
        public IActionResult ObterExemplo()
        {
            var despesa = new Despesa(
                "Aluguel",
                1500.00m,
                DateTime.Now,
                "Moradia",
                "Boleto Bancário"
                );
            var response = despesa.ToResponse();
            return Ok(response);
        }



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
