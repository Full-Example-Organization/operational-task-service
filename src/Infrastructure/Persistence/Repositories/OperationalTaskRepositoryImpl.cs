using System.Linq;
using System.Threading.Tasks;
using Core.Domain;

namespace Infrastructure.Persistence.Repositories
{
    public class OperationalTaskRepositoryImpl : OperationalTaskRepository
    {
        private readonly StubDb db;
        public OperationalTaskRepositoryImpl(StubDb db)
        {
            this.db = db;
        }

        public Task<OperationalTask> Add(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<OperationalTask> Find(string id)
        {
            return Task.Run(() => db.Tasks.FirstOrDefault());
        }

        public Task<OperationalTask> FindByTitle(string title)
        {
            throw new System.NotImplementedException();
        }

        public Task<OperationalTask> Remove(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}