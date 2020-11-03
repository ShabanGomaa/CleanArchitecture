using System.Threading.Tasks;
using ItLank.CleanArchitecture.SharedKernel;

namespace ItLank.CleanArchitecture.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}