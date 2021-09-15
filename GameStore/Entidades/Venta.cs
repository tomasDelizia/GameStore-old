namespace GameStore.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            DetallesDeVentas = new HashSet<DetalleVenta>();
        }

        [Key]
        public int NroFactura { get; set; }

        public int? IdTipoFactura { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaVenta { get; set; }

        public int? IdFormaPago { get; set; }

        public int? IdSocio { get; set; }

        public int? IdVendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVenta> DetallesDeVentas { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual FormaPago FormasDePago { get; set; }

        public virtual Socio Socio { get; set; }

        public virtual TipoFactura TiposDeFactura { get; set; }
    }
}