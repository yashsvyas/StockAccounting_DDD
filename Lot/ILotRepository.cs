using CostAccounting.Interfaces;
using System;

namespace CostAccounting
{
    public interface ILotRepository : IRepository<Lot, Guid>
    {
    }
}