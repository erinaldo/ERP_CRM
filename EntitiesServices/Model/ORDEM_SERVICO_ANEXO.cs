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
    
    public partial class ORDEM_SERVICO_ANEXO
    {
        public int ORSX_CD_ID { get; set; }
        public int ORSE_CD_ID { get; set; }
        public string ORSX_NM_TITULO { get; set; }
        public System.DateTime ORSX_DT_ANEXO { get; set; }
        public int ORSX_IN_TIPO { get; set; }
        public string ORSX_AQ_ARQUIVO { get; set; }
        public int ORSX_IN_ATIVO { get; set; }
    
        public virtual ORDEM_SERVICO ORDEM_SERVICO { get; set; }
    }
}