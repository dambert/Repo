namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLEADO")]
    public partial class EMPLEADO
    {
        public EMPLEADO()
        {
            VENTA = new HashSet<VENTA>();
        }

        [Required]
        [StringLength(100)]
        public string NUsername { get; set; }

        [Required]
        [StringLength(100)]
        public string NPassword { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CEmpleado { get; set; }

        public int? CTipoEmpleado { get; set; }

        public virtual ICollection<VENTA> VENTA { get; set; }

        public virtual TIPOEMPLEADO TIPOEMPLEADO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
