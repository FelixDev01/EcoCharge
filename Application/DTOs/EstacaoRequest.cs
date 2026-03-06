using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public record IniciarRecargaRequest(Guid EstacaoId);
    public record CriarEstacaoRequest(string Identificador, decimal PotenciaKw);
}
