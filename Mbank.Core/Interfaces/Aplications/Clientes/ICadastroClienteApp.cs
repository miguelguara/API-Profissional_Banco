using Mbank.Core.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Interfaces.Aplications.Clientes
{
    public interface ICadastroClienteApp
    {
        Task<Guid> CadastrarAsync(ClienteDTO cliente);
    }
}
