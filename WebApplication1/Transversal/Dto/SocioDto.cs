using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Controllers;

namespace WebApplication1.Transversal.Dto
{
    public class SocioDto
    {
        public byte[] Foto { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string cedula { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)] public System.DateTime Fecha_Nacimiento { get; set; }
        public string Lugar_De_Trabajo { get; set; }
        public string Direccion_Trabajo { get; set; }
        public string Telefono_Oficina { get; set; }
        public string TipoMembresiaId { get; set; }
        //public List<Afiliado> ListAfiliados { get; set; }


    }
}