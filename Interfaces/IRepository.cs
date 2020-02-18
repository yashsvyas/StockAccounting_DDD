using System.Linq;

namespace CostAccounting.Interfaces
{
    public interface IRepository<TAggregateRoot, TID> where TAggregateRoot:IAggregateRoot
    {
            
        void Add(TAggregateRoot aggRoot);

        TAggregateRoot GetById(TID id);

        void Update(TAggregateRoot aggregateRoot);
    }

}
