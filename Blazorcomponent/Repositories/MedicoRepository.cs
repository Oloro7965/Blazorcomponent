using Blazorcomponent.Components.Pages;
using Blazorcomponent.Models;
using System.ComponentModel;

namespace Blazorcomponent.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public async Task<List<medico>> GetAllAsync()
        {
            return new List<medico>
            {
                new medico{id=1,Nome="Pedro",CRM="4543543532" },
                new medico{ id = 2, Nome = "PedroR", CRM = "4543543532423432432" },
                new medico{ id = 3, Nome = "PedroRca", CRM = "45435435324324324" },
                new medico{ id = 4, Nome = "PedrorC", CRM = "4543543532423432" },
                new medico{ id = 5, Nome = "Pedro21312", CRM = "4543543532432432" }
            };
        }
    }
}
