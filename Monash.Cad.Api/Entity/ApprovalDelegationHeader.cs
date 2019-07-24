namespace Monash.Cad.Api.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApprovalDelegationHeader")]
    public partial class ApprovalDelegationHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApprovalDelegationHeader()
        {
            ApprovalDelegationDetails = new HashSet<ApprovalDelegationDetail>();
        }

        public int Id { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        [StringLength(15)]
        public string TransactionId { get; set; }

        public DateTime TransactionDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApprovalDelegationDetail> ApprovalDelegationDetails { get; set; }
    }
}
