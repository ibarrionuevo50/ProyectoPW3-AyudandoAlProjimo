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
    
    public partial class PropuestasDonacionesInsumos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropuestasDonacionesInsumos()
        {
            this.DonacionesInsumos = new HashSet<DonacionesInsumos>();
        }
    
        public int IdPropuestaDonacionInsumo { get; set; }
        public int IdPropuesta { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    
        public virtual Propuestas Propuestas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonacionesInsumos> DonacionesInsumos { get; set; }
    }
}
