namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USUARIO")]
    public partial class USUARIO
    {
        [Key]
        public int CUsuario { get; set; }

        [Required]
        [StringLength(100)]
        public string NNombres { get; set; }

        [StringLength(100)]
        public string NAPellidos { get; set; }

        [Required]
        [StringLength(8)]
        public string DNI { get; set; }

        public int? Telefono { get; set; }

        [StringLength(255)]
        public string TDireccion { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual EMPLEADO EMPLEADO { get; set; }
    }
}
