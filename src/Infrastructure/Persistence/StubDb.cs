using System.Collections.Generic;
using Core.Domain;

namespace Infrastructure.Persistence
{
    public class StubDb
    {
        public List<OperationalTask> Stocks = new List<OperationalTask>()
        {
            new OperationalTask("Add support for Task Types"),
            new OperationalTask("Add support for time tracking on tasks"),
            new OperationalTask("Add support for asignee")
        };	
    }
}