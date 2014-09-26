namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EVENTO")]
    public partial class EVENTO
    {
        public EVENTO()
        {
            ASIENTO_EVENTO = new HashSet<ASIENTO_EVENTO>();
            VENTA = new HashSet<VENTA>();
        }

        [Required]
        [StringLength(100)]
        public string NEvento { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CEvento { get; set; }

        public DateTime DFechaEvento { get; set; }

        [StringLength(255)]
        public string TDescripcion { get; set; }

        public virtual ICollection<ASIENTO_EVENTO> ASIENTO_EVENTO { get; set; }

        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}
