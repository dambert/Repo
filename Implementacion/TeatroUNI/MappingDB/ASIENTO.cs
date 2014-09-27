namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ASIENTO")]
    public partial class ASIENTO
    {
        public ASIENTO()
        {
            DETALLE_VENTA = new HashSet<DETALLE_VENTA>();
            ASIENTO_EVENTO = new HashSet<ASIENTO_EVENTO>();
        }

        [Key]
        public int CASiento { get; set; }

        [Required]
        [StringLength(1)]
        public string Letra { get; set; }

        public int Numero { get; set; }

        public int? CTipoAsiento { get; set; }

        public virtual ICollection<DETALLE_VENTA> DETALLE_VENTA { get; set; }

        public virtual TIPO_ASIENTO TIPO_ASIENTO { get; set; }

        public virtual ICollection<ASIENTO_EVENTO> ASIENTO_EVENTO { get; set; }
    }
}
