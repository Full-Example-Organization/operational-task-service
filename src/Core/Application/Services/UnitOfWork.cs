using System.Threading.Tasks;

namespace Core.Application.Services
{
    public interface UnitOfWork
    {
        Task CompleteAsync();
    }
}