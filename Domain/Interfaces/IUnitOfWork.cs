using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        // TASK PARA VERIFICAÇÃO SE AS MUDANÇAS FORAM PERSISTIDAS COM SUCESSO (RETORNA TRUE)
        Task<bool> CommitAsync();
    }
}
