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
    
    public partial class HallData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HallData()
        {
            this.HallWithStaffs = new HashSet<HallWithStaff>();
            this.RoomDatas = new HashSet<RoomData>();
            this.ExhibitionActivityDatas = new HashSet<ExhibitionActivityData>();
        }
    
        public System.Guid ID { get; set; }
        public string KnownName { get; set; }
        public string Introduction { get; set; }
        public string Region { get; set; }
        public string Extension { get; set; }
        public int CollectionCount { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HallWithStaff> HallWithStaffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomData> RoomDatas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExhibitionActivityData> ExhibitionActivityDatas { get; set; }
    }
}
