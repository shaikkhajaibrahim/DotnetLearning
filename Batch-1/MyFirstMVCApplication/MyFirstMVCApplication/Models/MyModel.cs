namespace MyFirstMVCApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<SportsEvent> SportsEvents { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Teachers)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.Address_Id);

            modelBuilder.Entity<SportsEvent>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.SportsEvent)
                .HasForeignKey(e => e.SportsEvent_EventName);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Teacher)
                .HasForeignKey(e => e.Teacher_TeacherId);
        }
    }
}
