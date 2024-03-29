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
    
    public partial class PLANO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLANO()
        {
            this.ASSINANTE_PAGAMENTO = new HashSet<ASSINANTE_PAGAMENTO>();
            this.ASSINANTE_PLANO = new HashSet<ASSINANTE_PLANO>();
        }
    
        public int PLAN_CD_ID { get; set; }
        public string PLAN_NM_NOME { get; set; }
        public Nullable<System.DateTime> PLAN_DT_CRIACAO { get; set; }
        public Nullable<int> PLAN_IN_ATIVO { get; set; }
        public string PLAN_DS_DESCRICAO { get; set; }
        public Nullable<int> PLAN_NR_USUARIOS { get; set; }
        public Nullable<int> PLAN_NR_CONTATOS { get; set; }
        public Nullable<int> PLAN_NR_EMAIL { get; set; }
        public Nullable<int> PLAN_NR_SMS { get; set; }
        public Nullable<int> PLAN_NR_WHATSAPP { get; set; }
        public Nullable<int> PLAN_NR_PROCESSOS { get; set; }
        public Nullable<int> PLAN_NR_ACOES { get; set; }
        public Nullable<decimal> PLAN_VL_PRECO { get; set; }
        public Nullable<int> PLPE_CD_ID { get; set; }
        public Nullable<System.DateTime> PLAN_DT_VALIDADE { get; set; }
        public Nullable<decimal> PLAN_VL_PROMOCAO { get; set; }
        public string PLAN_TX_SITE { get; set; }
        public Nullable<int> PLAN_IN_BLOCO { get; set; }
        public Nullable<int> PLAN_IN_NIVEL { get; set; }
        public Nullable<int> PLAN_IN_MENSAGENS { get; set; }
        public Nullable<int> PLAN_IN_CRM { get; set; }
        public Nullable<int> PLAN_IN_POSVENDA { get; set; }
        public Nullable<int> PLAN_IN_FINANCEIRO { get; set; }
        public Nullable<int> PLAN_IN_FATURA { get; set; }
        public Nullable<int> PLAN_IN_ESTOQUE { get; set; }
        public Nullable<int> PLAN_IN_PATRIMONIO { get; set; }
        public Nullable<int> PLAN_NR_PATRIMONIO { get; set; }
        public Nullable<int> PLAN_NR_PRODUTO { get; set; }
        public Nullable<int> PLAN_NR_FORNECEDOR { get; set; }
        public Nullable<int> PLAN_IN_VENDAS { get; set; }
        public Nullable<int> PLAN_IN_COMPRA { get; set; }
        public Nullable<int> PLAN_IN_SERVICOS { get; set; }
        public Nullable<int> PLAN_IN_ATENDIMENTOS { get; set; }
        public Nullable<int> PLAN_IN_OS { get; set; }
        public Nullable<int> PLAN_NR_COMPRA { get; set; }
        public Nullable<int> PLAN_NR_VENDA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSINANTE_PAGAMENTO> ASSINANTE_PAGAMENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSINANTE_PLANO> ASSINANTE_PLANO { get; set; }
        public virtual PLANO_PERIODICIDADE PLANO_PERIODICIDADE { get; set; }
    }
}
