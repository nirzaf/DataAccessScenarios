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
    
    public partial class RoomBooking
    {
        public System.Guid OID { get; set; }
        public Nullable<System.Guid> CapacityRequirement { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<System.Guid> Room { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
    
        public virtual CapacityRequirement CapacityRequirement1 { get; set; }
        public virtual Room Room1 { get; set; }
    }
}