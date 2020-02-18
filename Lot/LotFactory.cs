using System;
using CostAccounting;

namespace CostAccounting

{
    public static class LotFactory
    {
        public static Lot NewLotForNewAsset(string Ticker, DateTime buyDate, decimal price)
        {
            var securityInfoWithTicker = new SecurityInfo(Ticker,Ticker,price);

            var lot = new Lot(Guid.NewGuid(),securityInfoWithTicker,buyDate,price);


            return lot;
        }

        public static Lot NewLotForExistingAsset(Security existingSecurity, DateTime purchaseDate, decimal purchasePrice)
        {
            var securityInfoWithExistingSecurity = new SecurityInfo(
                    existingSecurity.Identifier,
                    existingSecurity.Name,
                    existingSecurity.Price
                );

            var lot = new Lot(Guid.NewGuid(), securityInfoWithExistingSecurity, purchaseDate, purchasePrice);

            return lot;
        }
    }
}