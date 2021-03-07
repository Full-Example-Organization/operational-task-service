using System.Threading.Tasks;

namespace Core.Domain
{
    public interface OperationalTaskRepository
    {
        Task Add(string id);
        Task<OperationalTask> Find(string id);
        Task<OperationalTask> FindByTitle(string title);
        Task Remove(string id);
    }
} 