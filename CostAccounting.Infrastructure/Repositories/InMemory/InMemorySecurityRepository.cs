using System;
using CostAccounting.Security;
using CostAccounting.Lot;
using System.Collections.Generic;
using System.Linq;


namespace CostAccounting.Infrastructure.Repositories.InMemory
{
    public sealed class InMemorySecurityRepository : ISecurityRepository
    {

        public List<Security.Security> Security { get; } = new List<Security.Security>();

        public void Add(Security.Security aggRoot)
        {
            Security.Add(aggRoot);
        }

        public Security.Security GetById(string id)
        {
            return Security.FirstOrDefault(i => i.Identifier == id);
        }

        public void Update(Security.Security aggRoot)
        {
            var existingInstrument = Security.FirstOrDefault(i => i.IsSameAs(aggRoot));
            if (existingInstrument != null)
                Security[Security.IndexOf(existingInstrument)] = aggRoot;
        }
    }
}
