//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiesServices.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RESUMO_VENDA
    {
        public int REVE_CD_ID { get; set; }
        public int ASSI_CD_ID { get; set; }
        public Nullable<System.DateTime> REVE_DT_DATA { get; set; }
        public Nullable<int> REVE_NR_NUMERO { get; set; }
        public Nullable<decimal> REVE_VL_VALOR { get; set; }
    
        public virtual ASSINANTE ASSINANTE { get; set; }
    }
}
