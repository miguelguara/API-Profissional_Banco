using Mbank.Core.Entitys;
using Mbank.Core.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Interfaces.Aplications.Clientes
{
    public interface IAlterarClienteApp
    {
        Task<Cliente> AlterarCliente(Guid id, AlterarClienteDTO altCliente);
    }
}
