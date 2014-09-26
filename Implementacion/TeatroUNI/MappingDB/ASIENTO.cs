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
            ASIENTO_EVENTO = new HashSet<ASIENTO_EVENTO>();
            VENTA = new HashSet<VENTA>();
        }

        [Key]
        public int CASiento { get; set; }

        [Required]
        [StringLength(1)]
        public string Letra { get; set; }

        public int Numero { get; set; }

        public int? CTipoAsiento { get; set; }

        public virtual TIPO_ASIENTO TIPO_ASIENTO { get; set; }

        public virtual ICollection<ASIENTO_EVENTO> ASIENTO_EVENTO { get; set; }

        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}
