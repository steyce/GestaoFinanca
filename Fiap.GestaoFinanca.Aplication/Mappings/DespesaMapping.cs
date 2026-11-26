using Fiap.GestaoFinanca.Domain.Entities;
using Fiap.GestaoFinanca.Application.DTOs;

namespace Fiap.GestaoFinanca.Application.Mappings
{
    public static class DespesaMapping
    {
        public static DespesaResponse ToResponse(this Despesa despesa)
        {
            return new DespesaResponse(
                despesa.Id,
                despesa.Descricao,
                despesa.Valor,
                despesa.Data,
                despesa.Categoria,
                despesa.FormaPagamento,
                despesa.CriadoEm,
                Observacao: null
                );
             
        }

    }
}
