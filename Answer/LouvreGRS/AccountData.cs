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
    
    public partial class AccountData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountData()
        {
            this.TravelAgencyUserDatas = new HashSet<TravelAgencyUserData>();
        }
    
        public System.Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginAccount { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual StaffData StaffData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TravelAgencyUserData> TravelAgencyUserDatas { get; set; }
    }
}
