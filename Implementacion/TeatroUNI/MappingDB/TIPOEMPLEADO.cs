namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TIPOEMPLEADO")]
    public partial class TIPOEMPLEADO
    {
        public TIPOEMPLEADO()
        {
            EMPLEADO = new HashSet<EMPLEADO>();
        }

        [Key]
        public int CTipoEmpleado { get; set; }

        [Required]
        [StringLength(100)]
        public string NTipoEmpleado { get; set; }

        public virtual ICollection<EMPLEADO> EMPLEADO { get; set; }
    }
}
