namespace Monash.Cad.Api.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApprovalDelegationDetail")]
    public partial class ApprovalDelegationDetail
    {
        public int Id { get; set; }

        public int HeaderId { get; set; }

        public int DelegateFromId { get; set; }

        [StringLength(15)]
        public string DelegateFromName { get; set; }

        public int DelegateToId { get; set; }

        [StringLength(15)]
        public string DelegateToName { get; set; }

        public DateTime? DelegateFromDate { get; set; }

        public DateTime? DelegateToDate { get; set; }

        public int? TargetSystemId { get; set; }

        [StringLength(25)]
        public string TargetSystemName { get; set; }

        public bool? IsApprover { get; set; }

        public bool? IsVerifyer { get; set; }

        [StringLength(10)]
        public string Role { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsLogicalDelete { get; set; }

        public virtual ApprovalDelegationHeader ApprovalDelegationHeader { get; set; }
    }
}
