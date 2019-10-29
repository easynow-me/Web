using System;

namespace EasyNow.BusinessObject.DataAccess.Entities
{
    public abstract class BaseEntity<TKey> : IEntity where TKey: IComparable<TKey>
    {
        public TKey Id { get; set; }
    }
}