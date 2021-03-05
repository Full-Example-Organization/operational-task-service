using System.Threading.Tasks;

namespace Core.Domain.OperationalTask.Repositories
{
    public interface IOperationalTaskRepository
    {
        Task<OperationalTask> Get(string id);
        // Task<OperationalTask> Get(string id);
    }
}