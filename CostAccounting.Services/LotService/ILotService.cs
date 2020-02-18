using System;
namespace CostAccounting.Services.LotService
{
    public interface ILotService
    {
        void AddLotService(string Identifier, DateTime purchaseDate, Decimal Price);
   
    }
}
