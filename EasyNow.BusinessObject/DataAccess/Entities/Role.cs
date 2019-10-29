using System;

namespace EasyNow.BusinessObject.DataAccess.Entities
{
    public class Role<TKey> : BaseAuditEntity<TKey> where TKey : IComparable<TKey>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}