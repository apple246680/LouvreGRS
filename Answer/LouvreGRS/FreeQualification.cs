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
    
    public partial class FreeQualification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FreeQualification()
        {
            this.GroupRegistrationVisitors = new HashSet<GroupRegistrationVisitor>();
        }
    
        public int ID { get; set; }
        public string FreeItem { get; set; }
        public string FreeClassify { get; set; }
        public string IsValid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupRegistrationVisitor> GroupRegistrationVisitors { get; set; }
    }
}