namespace CostAccounting.Interfaces
{
    public interface IEntity
    {
        public interface IValueObject
        {
            bool IsEqualTo(object obj);
        }

    }
}