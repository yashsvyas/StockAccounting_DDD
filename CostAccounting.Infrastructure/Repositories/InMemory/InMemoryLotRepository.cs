using System;
using CostAccounting.Security;
using CostAccounting.Lot;
using System.Collections.Generic;
using System.Linq;

namespace CostAccounting.Infrastructure.Repositories.InMemory
{
    public class InMemoryLotRepository : ILotRepository
    {
        public List<Lot.Lot> Lots { get; } = new List<Lot.Lot>();

        public void Add(Lot.Lot aggRoot)
        {
            Lots.Add(aggRoot);
        }

        public Lot.Lot GetById(Guid id)
        {
            return Lots.FirstOrDefault(l => l.ID == id);
        }

        public void Update(Lot.Lot aggRoot)
        {
            var existingLot = Lots.FirstOrDefault(l => l.IsEqualTo(aggRoot));
            if (existingLot != null)
                Lots[Lots.IndexOf(existingLot)] = aggRoot;
        }

        public void FindAll(Guid id)
        {
            return Lots.FirstOrDefault(l => l.ID == id);
        }
    }
}
