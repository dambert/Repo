namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASIENTO_EVENTO
    {
        [Key]
        [Column(Order = 0)]
        public int CASiento { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CEvento { get; set; }

        public int? CEstadoAsiento { get; set; }

        public virtual ASIENTO ASIENTO { get; set; }

        public virtual EVENTO EVENTO { get; set; }

        public virtual ESTADOASIENTO ESTADOASIENTO { get; set; }
    }
}
