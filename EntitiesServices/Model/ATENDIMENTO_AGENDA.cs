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
    
    public partial class ATENDIMENTO_AGENDA
    {
        public int ATAG_CD_ID { get; set; }
        public int ATEN_CD_ID { get; set; }
        public int AGEN_CD_ID { get; set; }
        public int ATAG_IN_ATIVO { get; set; }
    
        public virtual AGENDA AGENDA { get; set; }
        public virtual ATENDIMENTO ATENDIMENTO { get; set; }
    }
}