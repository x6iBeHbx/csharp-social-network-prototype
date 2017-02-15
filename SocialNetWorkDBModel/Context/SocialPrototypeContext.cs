using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetWorkDBModel.userData;
using SocialNetWorkDBModel.userData.professions;

namespace SocialNetWorkDBModel.Context
{
    class SocialPrototypeContext : DbContext
    {
        public SocialPrototypeContext() : base("DBConnection")
        {
        }


        public DbSet<User> Users{ get; set; }
        //public DbSet<UserData> UsersData { get; set; }
        public DbSet<Professions> Professions { get; set; }
        //public DbSet<StatesEnum> UserState { get; set; }
        //public DbSet<SexEnum> UserSex { get; set; }
        
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UserData>().HasOptional(x => x.User);
        //    modelBuilder.Entity<User>().HasRequired(x => x.UserData);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
