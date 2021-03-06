using Core.Domain;
using NUnit.Framework;

namespace Tests.UnitTests
{
    [TestFixture]
    public class OperationalTaskTests
    {
        [Test]
        public void SetTitle_CalledWithString_ShouldSucced()
        {
            var initialTitle = "Cool task";
            var operationalTask = new OperationalTask(initialTitle);
            var newTitle = "Comprehensive task";

            operationalTask.SetTitle(newTitle);
            
            Assert.AreEqual(operationalTask.Title, newTitle);
        }        
    }
}