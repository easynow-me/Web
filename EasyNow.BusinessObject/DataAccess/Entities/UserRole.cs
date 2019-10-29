using System;

namespace EasyNow.BusinessObject.DataAccess.Entities
{
    public class UserRole<TKey> : BaseAuditEntity<TKey> where TKey : IComparable<TKey>
    {
        public TKey UserId { get; set; }
        public TKey RoleId { get; set; }

        public virtual User<TKey> User { get; set; }

        public virtual Role<TKey> Role { get; set; }
    }
}