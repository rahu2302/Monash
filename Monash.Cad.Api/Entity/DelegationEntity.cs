namespace Monash.Cad.Api.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DelegationEntity : DbContext
    {
        public DelegationEntity()
            : base("name=DelegationEntity")
        {
        }

        public virtual DbSet<ApprovalDelegationDetail> ApprovalDelegationDetails { get; set; }
        public virtual DbSet<ApprovalDelegationHeader> ApprovalDelegationHeaders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApprovalDelegationDetail>()
                .Property(e => e.DelegateFromName)
                .IsFixedLength();

            modelBuilder.Entity<ApprovalDelegationDetail>()
                .Property(e => e.DelegateToName)
                .IsFixedLength();

            modelBuilder.Entity<ApprovalDelegationDetail>()
                .Property(e => e.TargetSystemName)
                .IsFixedLength();

            modelBuilder.Entity<ApprovalDelegationDetail>()
                .Property(e => e.Role)
                .IsFixedLength();

            modelBuilder.Entity<ApprovalDelegationHeader>()
                .Property(e => e.TransactionId)
                .IsUnicode(false);

            modelBuilder.Entity<ApprovalDelegationHeader>()
                .HasMany(e => e.ApprovalDelegationDetails)
                .WithRequired(e => e.ApprovalDelegationHeader)
                .HasForeignKey(e => e.HeaderId)
                .WillCascadeOnDelete(false);
        }
    }
}
