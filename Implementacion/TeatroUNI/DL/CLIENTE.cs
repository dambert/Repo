//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENTE
    {
        public CLIENTE()
        {
            this.VENTA = new HashSet<VENTA>();
        }
    
        public int CCliente { get; set; }
        public string RUC { get; set; }
    
        public virtual ICollection<VENTA> VENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
