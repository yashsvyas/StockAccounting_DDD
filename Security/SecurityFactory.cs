using System;
using CostAccounting;

namespace CostAccounting
{ 
    public static class SecurityFactory
    {
        public static Security NewInstrumentByInfo(SecurityInfo secInfo)
        {
            var newSecurity = new Security(
                secInfo.Identifier,
                secInfo.Name,
                secInfo.Price);

            return newSecurity;
        }
    }
}
