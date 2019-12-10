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
    using System.ComponentModel.DataAnnotations;

    public partial class Socio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Socio()
        {
            this.Afiliadoes = new HashSet<Afiliado>();
            this.Cliente_Membresia = new HashSet<Cliente_Membresia>();
        }
    
        public int Id_Socio { get; set; }
        public byte[] Foto { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string cedula { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        [Display(Name = "Fecha De Nacimiento")]
         [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime Fecha_Nacimiento { get; set; }
        [Display(Name = "Lugar De Trabajo")]

        public string Lugar_De_Trabajo { get; set; }
        [Display(Name = "Direccion De Trabajo")]

        public string Direccion_Trabajo { get; set; }
        [Display(Name = "Telefono De Oficina")]

        public string Telefono_Oficina { get; set; }
        [Display(Name ="Tipo De Membresia")]
        public string Tipo_Membresia { get; set; }
        [Display(Name = "Fecha Inicio Membresia")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Fecha_Inicial { get; set; }
        [Display(Name = "Fecha Final Membresia")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Fecha_Final { get; set; }
        public Nullable<bool> Estado { get; set; }

        public List<Afiliado> ListAfiliados
        {
            get { return new List<Afiliado>(); }
            set { Afiliadoes = value; }

        }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Afiliado> Afiliadoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Membresia> Cliente_Membresia { get; set; }
    }
}
