using System.Threading.Tasks;
using Core.Domain;

namespace Core.Application.Services
{
    public interface OperationalTaskService
    {
        Task<OperationalTask> GetOperationalTask();
    }
}