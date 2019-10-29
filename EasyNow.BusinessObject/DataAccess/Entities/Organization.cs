using System;

namespace EasyNow.BusinessObject.DataAccess.Entities
{
    public class Organization<TKey> : BaseAuditEntity<TKey> where TKey : struct,IComparable<TKey>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public TKey? ParentId { get; set; }
    }
}