using Mbank.Core.Entitys;
using Mbank.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mbank.Core.Interfaces.Aplications
{
    public interface IAlterarClienteApp
    {
        Task<Cliente> AlterarCliente(Guid id, AlterarClienteDTO altCliente);
    }
}
