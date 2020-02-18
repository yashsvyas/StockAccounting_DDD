using System;
using CostAccounting.Interfaces;

namespace CostAccounting
{
    /*

    SecurityInfo Value Object. All properties are immutable because one defined, their property is final.

    Reference:   https://softwareengineering.stackexchange.com/questions/125817/what-is-a-value-object-in-domain-driven-design
    Well explained by Pepito Fernandez.


    */

    public sealed class SecurityInfo : IValueObject
    {
        public SecurityInfo(string Identifier, string Name, decimal Price){
            this.Identifier = Identifier;
            this.Name = Name;
            this.Price = Price;
        }
        public string Identifier { get; }

        public string Name {get; }

        public decimal Price {get; }  

        public bool IsEqualTo(object obj)
        {
            return obj is SecurityInfo ii
            ? (Identifier == ii.Identifier && Name == ii.Name && Price == ii.Price)
            : false;
        }
 
    }
}