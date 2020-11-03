using ItLank.CleanArchitecture.Core.Entities;
using ItLank.CleanArchitecture.SharedKernel;

namespace ItLank.CleanArchitecture.Core.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}