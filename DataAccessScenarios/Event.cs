//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessScenarios
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            this.CapacityRequirements = new HashSet<CapacityRequirement>();
        }
    
        public System.Guid OID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.Guid> Venue { get; set; }
        public Nullable<System.Guid> Customer { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CapacityRequirement> CapacityRequirements { get; set; }
        public virtual Customer Customer1 { get; set; }
        public virtual Venue Venue1 { get; set; }
    }
}
