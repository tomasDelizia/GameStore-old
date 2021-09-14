namespace GameStore.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TiposDeArticulo")]
    public partial class TipoArticulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoArticulo()
        {
            Articulos = new HashSet<Articulo>();
        }

        [Key]
        public int IdTipoArticulo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
