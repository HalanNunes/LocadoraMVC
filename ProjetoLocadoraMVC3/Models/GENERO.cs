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
    
    public partial class GENERO
    {
        public GENERO()
        {
            this.TITULO = new HashSet<TITULO>();
        }
    
        public long CD_GENERO { get; set; }
        public string DS_GENERO { get; set; }
    
        public virtual ICollection<TITULO> TITULO { get; set; }
    }
}
