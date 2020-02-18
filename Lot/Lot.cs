using CostAccounting.Interfaces;
using System;

namespace CostAccounting
{
    public class Lot : IAggregateRoot
    {
        public Lot(Guid ID, SecurityInfo SecurityInfo, DateTime PurchaseDate, decimal Price)
        {
            this.ID = ID;
            this.SecurityInfo = SecurityInfo;
            this.PurchaseDate = PurchaseDate;
            this.Price = Price;
        }
        public Guid ID { get; }
        public decimal Price { get; }  

        public DateTime PurchaseDate{get;}

        public SecurityInfo SecurityInfo {get; private set;}

        public bool IsEqualTo(object obj)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSecurityPrice(decimal newPrice){
            SecurityInfo = new SecurityInfo(SecurityInfo.Identifier, SecurityInfo.Name, newPrice);
        }
    }
}