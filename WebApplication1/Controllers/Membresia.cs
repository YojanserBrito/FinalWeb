//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Membresia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Membresia()
        {
            this.Cliente_Membresia = new HashSet<Cliente_Membresia>();
        }
    
        public int Id_Membresia { get; set; }
        public string Tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Membresia> Cliente_Membresia { get; set; }
    }
}
