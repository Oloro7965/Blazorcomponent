using Blazorcomponent.Models;

namespace Blazorcomponent.Repositories
{
    public interface IMedicoRepository
    {
        Task<List<medico>> GetAllAsync();
    }
}
