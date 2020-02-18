using System;
namespace CostAccounting;
{
    public sealed class LotCreatedDomainEvent
    {
        public LotCreatedDomainEvent(Guid LotId)
        {
            this.LotId = LotId;
        }
        public Guid LotId { get; }
    }
}
