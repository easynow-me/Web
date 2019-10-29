using System;

namespace EasyNow.BusinessObject.DataAccess.Entities
{
    public class UserOrganization<TKey> : BaseAuditEntity<TKey> where TKey : struct, IComparable<TKey>
    {
        public TKey UserId { get; set; }
        public TKey OrganizationId { get; set; }

        public virtual User<TKey> User { get; set; }

        public virtual Organization<TKey> Organization { get; set; }
    }
}