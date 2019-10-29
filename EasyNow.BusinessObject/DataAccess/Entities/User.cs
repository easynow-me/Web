using System;

namespace EasyNow.BusinessObject.DataAccess.Entities
{
    public class User<TKey> : BaseAuditEntity<TKey> where TKey : IComparable<TKey>
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
    }
}