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
    
    public partial class SERVICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICO()
        {
            this.ATENDIMENTO = new HashSet<ATENDIMENTO>();
            this.ORDEM_SERVICO = new HashSet<ORDEM_SERVICO>();
            this.ORDEM_SERVICO_SERVICO = new HashSet<ORDEM_SERVICO_SERVICO>();
            this.SERVICO_ANEXO = new HashSet<SERVICO_ANEXO>();
            this.SERVICO_TABELA_PRECO = new HashSet<SERVICO_TABELA_PRECO>();
        }
    
        public int SERV_CD_ID { get; set; }
        public int ASSI_CD_ID { get; set; }
        public Nullable<int> FILI_CD_ID { get; set; }
        public Nullable<int> CASE_CD_ID { get; set; }
        public Nullable<int> UNID_CD_ID { get; set; }
        public Nullable<int> NBSE_CD_ID { get; set; }
        public string SERV_NM_NOME { get; set; }
        public string SERV_DS_DESCRICAO { get; set; }
        public System.DateTime SERV_DT_CADASTRO { get; set; }
        public int SERV_IN_ATIVO { get; set; }
        public string SERV_CD_CODIGO { get; set; }
        public string SERV_TX_OBSERVACOES { get; set; }
        public Nullable<int> SERV_NR_DURACAO { get; set; }
        public Nullable<decimal> SERV_VL_PRECO { get; set; }
        public Nullable<int> SERV_NR_DURACAO_EXPRESSA { get; set; }
        public Nullable<decimal> SERV_VL_VALOR_EXPRESSO { get; set; }
        public Nullable<int> SERV_IN_LOCAL { get; set; }
        public Nullable<decimal> SERV_VL_VISITA { get; set; }
    
        public virtual ASSINANTE ASSINANTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATENDIMENTO> ATENDIMENTO { get; set; }
        public virtual CATEGORIA_SERVICO CATEGORIA_SERVICO { get; set; }
        public virtual FILIAL FILIAL { get; set; }
        public virtual NOMENCLATURA_BRAS_SERVICOS NOMENCLATURA_BRAS_SERVICOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEM_SERVICO> ORDEM_SERVICO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEM_SERVICO_SERVICO> ORDEM_SERVICO_SERVICO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICO_ANEXO> SERVICO_ANEXO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICO_TABELA_PRECO> SERVICO_TABELA_PRECO { get; set; }
        public virtual UNIDADE UNIDADE { get; set; }
    }
}
