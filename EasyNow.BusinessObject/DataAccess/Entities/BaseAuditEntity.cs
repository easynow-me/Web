using System;

namespace EasyNow.BusinessObject.DataAccess.Entities
{
    public abstract class BaseAuditEntity<TKey> : BaseEntity<TKey> where TKey : IComparable<TKey>
    {
        public TKey Creator { get; set; }
        public DateTime CreateTime { get; set; }
        public TKey Updater { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}