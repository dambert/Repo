namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTE")]
    public partial class CLIENTE
    {
        public CLIENTE()
        {
            VENTA = new HashSet<VENTA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CCliente { get; set; }

        [StringLength(18)]
        public string RUC { get; set; }

        public virtual ICollection<VENTA> VENTA { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
