//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LouvreGRS
{
    using System;
    using System.Collections.Generic;
    
    public partial class HallWithStaff
    {
        public System.Guid AccountID { get; set; }
        public System.Guid HallID { get; set; }
        public Nullable<int> Responsibility { get; set; }
    
        public virtual HallData HallData { get; set; }
        public virtual StaffData StaffData { get; set; }
    }
}
