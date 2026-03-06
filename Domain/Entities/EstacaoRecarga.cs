using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class EstacaoRecarga(string identificador, decimal potenciaKw)
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Identificador { get; private set; } = identificador;
        public decimal PotenciaKw { get; private set; } = potenciaKw;
        public bool EstaOcupada { get; private set; }
        public bool EmManutencao { get; private set; }


        // DDD A ENTIDADE DEVE SE AUTOVALIDAR, ENTÃO A LÓGICA DE VALIDAÇÃO DEVE ESTAR AQUI
        public void IniciarRecarga()
        {
            if (EmManutencao)
            {
                throw new DomainException("Não é possivel iniciar a recarga em uma estação em manutenção.");
            }
            if (EstaOcupada)
            {
                throw new DomainException("Estação já está em uso.");
            }
        }
    }
}
