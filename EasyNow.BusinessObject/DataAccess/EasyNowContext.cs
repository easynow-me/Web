using EasyNow.BusinessObject.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EasyNow.BusinessObject.DataAccess
{
    public class EasyNowContext<TKey>:DbContext where TKey : struct, IComparable<TKey>
    {
        public DbSet<User<TKey>> User { get; set; }
        public DbSet<Role<TKey>> Role { get; set; }
        public DbSet<Privilege<TKey>> Privilege { get; set; }
        public DbSet<Organization<TKey>> Organization { get; set; }
        public DbSet<UserRole<TKey>> UserRole { get; set; }
        public DbSet<RolePrivilege<TKey>> RolePrivilege { get; set; }
        public DbSet<UserOrganization<TKey>> UserOrganization { get; set; }
    }
}
