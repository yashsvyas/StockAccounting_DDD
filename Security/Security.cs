using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CostAccounting.Interfaces;

namespace CostAccounting
{
    public sealed class Security : IAggregateRoot
    {
        public Security(string Identifier, string Name, decimal Price, List<Guid> lotIDs = null)
        {
            this.Identifier = Identifier;
            this.Name = Name;
            this.Price = Price;
            this.lotIDs = lotIDs ?? new List<Guid>();
        }

        public string Identifier { get; }

        public string Name { get; }

        public decimal Price { get; private set; }

        private readonly List<Guid> lotIDs;

        public ReadOnlyCollection<Guid> LotIdList => lotIDs.AsReadOnly();

        public void AttachLotId(Guid Id)
        {
            lotIDs.Add(Id);
        }

        public void UpdatePrice(decimal newPrice)
        {
            Price = newPrice;
        }

        public bool IsSameAs(object obj)
        {
            return obj is Security otherSecurity
                ? Identifier == otherSecurity.Identifier
                : false;
        }


    }
}