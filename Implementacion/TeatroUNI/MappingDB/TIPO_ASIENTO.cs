namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_ASIENTO
    {
        public TIPO_ASIENTO()
        {
            ASIENTO = new HashSet<ASIENTO>();
        }

        [Key]
        public int CTipoAsiento { get; set; }

        [Required]
        [StringLength(100)]
        public string NTipoAsiento { get; set; }

        public double Precio { get; set; }

        [Required]
        [StringLength(100)]
        public string NColor { get; set; }

        [StringLength(255)]
        public string TDescripcion { get; set; }

        public virtual ICollection<ASIENTO> ASIENTO { get; set; }
    }
}
