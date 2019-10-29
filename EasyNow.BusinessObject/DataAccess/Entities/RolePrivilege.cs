using System;

namespace EasyNow.BusinessObject.DataAccess.Entities
{
    public class RolePrivilege<TKey> : BaseAuditEntity<TKey> where TKey : IComparable<TKey>
    {
        public TKey UserId { get; set; }
        public TKey PrivilegeId { get; set; }

        public virtual User<TKey> User { get; set; }

        public virtual Privilege<TKey> Privilege { get; set; }
    }
}