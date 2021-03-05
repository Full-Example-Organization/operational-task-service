using System.Threading.Tasks;
using Core.Domain;

namespace Core.Application.Services.Implementations
{
    public class OperationalTaskServiceImpl : OperationalTaskService
    {
        private readonly OperationalTaskRepository taskRepository;
        public OperationalTaskServiceImpl(OperationalTaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }
        public async Task<OperationalTask> GetOperationalTask()
        {
            return await taskRepository.Find("Add support for Task Types");
        }
    }
}