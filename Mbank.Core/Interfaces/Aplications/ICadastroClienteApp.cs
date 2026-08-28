using Mbank.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Interfaces.Aplications
{
    public interface ICadastroClienteApp
    {
        Task<Guid> CadastrarAsync(ClienteDTO cliente);
    }
}
