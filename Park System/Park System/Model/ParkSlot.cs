//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Park_System.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParkSlot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParkSlot()
        {
            this.UserInformation = new HashSet<UserInformation>();
        }
    
        public Nullable<int> parkSlot { get; set; }
        public string AuserPlatenum { get; set; }
        public string AuserTypeCar { get; set; }
        public string AuserTimeOut { get; set; }
        public string AuserTimeArrive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInformation> UserInformation { get; set; }
    }
}
