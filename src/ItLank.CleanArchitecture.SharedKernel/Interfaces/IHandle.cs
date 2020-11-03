using System.Threading.Tasks;
using ItLank.CleanArchitecture.SharedKernel;

namespace ItLank.CleanArchitecture.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}