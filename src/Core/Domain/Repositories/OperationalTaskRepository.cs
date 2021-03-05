using System.Threading.Tasks;

namespace Core.Domain
{
    public interface OperationalTaskRepository
    {
        Task<OperationalTask> Add(string id);
        Task<OperationalTask> Find(string id);
        Task<OperationalTask> FindByTitle(string title);
        Task<OperationalTask> Remove(string id);
    }
} 