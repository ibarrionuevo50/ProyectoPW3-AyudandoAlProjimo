//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonacionesHorasTrabajo
    {
        public int IdDonacionHorasTrabajo { get; set; }
        public int IdPropuestaDonacionHorasTrabajo { get; set; }
        public int IdUsuario { get; set; }
        public int Cantidad { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
    
        public virtual PropuestasDonacionesHorasTrabajo PropuestasDonacionesHorasTrabajo { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
