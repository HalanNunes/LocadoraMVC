//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoLocadoraMVC3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOCACAO
    {
        public long CD_CLIENTE { get; set; }
        public long CD_COPIA { get; set; }
        public System.DateTime DT_LOCACAO { get; set; }
        public Nullable<System.DateTime> DT_DEVOLUCAO { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual COPIA COPIA { get; set; }
    }
}
