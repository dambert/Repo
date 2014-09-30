namespace MappingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENTA")]
    public partial class VENTA
    {
        public VENTA()
        {
            DETALLE_VENTA = new HashSet<DETALLE_VENTA>();
        }

        [Key]
        public int CVenta { get; set; }

        public double MontoTotal { get; set; }

        public DateTime DFechaVenta { get; set; }

        public int? CUsuario { get; set; }

        public int CEmpleado { get; set; }

        public int? CCliente { get; set; }

        public int CEvento { get; set; }

        [StringLength(1)]
        public string FBoleta { get; set; }

        [StringLength(1)]
        public string FFactura { get; set; }

        [StringLength(18)]
        public string RUC { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual ICollection<DETALLE_VENTA> DETALLE_VENTA { get; set; }

        public virtual EMPLEADO EMPLEADO { get; set; }

        public virtual EVENTO EVENTO { get; set; }
    }
}
