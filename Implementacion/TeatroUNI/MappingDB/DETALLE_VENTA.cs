namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DETALLE_VENTA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CVenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CASiento { get; set; }

        [StringLength(255)]
        public string TDescripcion { get; set; }

        public virtual ASIENTO ASIENTO { get; set; }

        public virtual VENTA VENTA { get; set; }
    }
}
