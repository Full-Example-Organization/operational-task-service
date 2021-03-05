using System.Threading.Tasks;

namespace Core.Application.Services
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}