namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ESTADOASIENTO")]
    public partial class ESTADOASIENTO
    {
        public ESTADOASIENTO()
        {
            ASIENTO_EVENTO = new HashSet<ASIENTO_EVENTO>();
        }

        [Key]
        public int CEstadoAsiento { get; set; }

        [Required]
        [StringLength(100)]
        public string NEstadoAsiento { get; set; }

        public virtual ICollection<ASIENTO_EVENTO> ASIENTO_EVENTO { get; set; }
    }
}
