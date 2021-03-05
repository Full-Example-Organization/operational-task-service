using System.Threading.Tasks;
using Core.Domain.Entities;

namespace Core.Domain.Repositories
{
    public interface IOperationalTaskRepository
    {
        Task<OperationalTask> Add(string id);
        Task<OperationalTask> Find(string id);
        Task<OperationalTask> Remove(string id);
    }
} 