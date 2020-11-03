using System.Threading.Tasks;
using ItLank.CleanArchitecture.SharedKernel.Interfaces;
using ItLank.CleanArchitecture.SharedKernel;

namespace ItLank.CleanArchitecture.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
