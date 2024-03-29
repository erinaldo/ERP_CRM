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
    
    public partial class PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUTO()
        {
            this.ATENDIMENTO = new HashSet<ATENDIMENTO>();
            this.FICHA_TECNICA = new HashSet<FICHA_TECNICA>();
            this.FICHA_TECNICA_DETALHE = new HashSet<FICHA_TECNICA_DETALHE>();
            this.ITEM_PEDIDO_COMPRA = new HashSet<ITEM_PEDIDO_COMPRA>();
            this.ITEM_PEDIDO_VENDA = new HashSet<ITEM_PEDIDO_VENDA>();
            this.MOVIMENTO_ESTOQUE_PRODUTO = new HashSet<MOVIMENTO_ESTOQUE_PRODUTO>();
            this.ORDEM_SERVICO = new HashSet<ORDEM_SERVICO>();
            this.ORDEM_SERVICO_PRODUTO = new HashSet<ORDEM_SERVICO_PRODUTO>();
            this.PRECO_PRODUTO = new HashSet<PRECO_PRODUTO>();
            this.PRODUTO_ANEXO = new HashSet<PRODUTO_ANEXO>();
            this.PRODUTO_BARCODE = new HashSet<PRODUTO_BARCODE>();
            this.PRODUTO_ESTOQUE_FILIAL = new HashSet<PRODUTO_ESTOQUE_FILIAL>();
            this.PRODUTO_FORNECEDOR = new HashSet<PRODUTO_FORNECEDOR>();
            this.PRODUTO_GRADE = new HashSet<PRODUTO_GRADE>();
            this.PRODUTO_KIT = new HashSet<PRODUTO_KIT>();
            this.PRODUTO_KIT1 = new HashSet<PRODUTO_KIT>();
            this.PRODUTO_TABELA_PRECO = new HashSet<PRODUTO_TABELA_PRECO>();
        }
    
        public int PROD_CD_ID { get; set; }
        public int ASSI_CD_ID { get; set; }
        public Nullable<int> FILI_CD_ID { get; set; }
        public Nullable<int> CAPR_CD_ID { get; set; }
        public Nullable<int> SCPR_CD_ID { get; set; }
        public Nullable<int> UNID_CD_ID { get; set; }
        public Nullable<int> PROR_CD_ID { get; set; }
        public string PROD_NM_NOME { get; set; }
        public string PROD_DS_DESCRICAO { get; set; }
        public int PROD_QN_QUANTIDADE_MINIMA { get; set; }
        public int PROD_QN_QUANTIDADE_INICIAL { get; set; }
        public int PROD_QN_ESTOQUE { get; set; }
        public Nullable<System.DateTime> PROD_DT_ULTIMA_MOVIMENTACAO { get; set; }
        public int PROD_IN_AVISA_MINIMO { get; set; }
        public System.DateTime PROD_DT_CADASTRO { get; set; }
        public int PROD_IN_ATIVO { get; set; }
        public string PROD_AQ_FOTO { get; set; }
        public string PROD_CD_CODIGO { get; set; }
        public Nullable<int> PROD_IN_TIPO_PRODUTO { get; set; }
        public Nullable<decimal> PROD_VL_PRECO_VENDA { get; set; }
        public Nullable<decimal> PROD_VL_PRECO_PROMOCAO { get; set; }
        public string PROD_DS_INFORMACOES { get; set; }
        public Nullable<int> PROD_NR_GARANTIA { get; set; }
        public Nullable<int> PROD_QN_QUANTIDADE_MAXIMA { get; set; }
        public Nullable<int> PROD_QN_RESERVA_ESTOQUE { get; set; }
        public string PROD_NR_REFERENCIA { get; set; }
        public Nullable<int> PROD_IN_BALANCA_PDV { get; set; }
        public Nullable<int> PROD_IN_BALANCA_RETAGUARDA { get; set; }
        public Nullable<int> PROD_NR_DIAS_VALIDADE { get; set; }
        public Nullable<int> PROD_IN_TIPO_COMBO { get; set; }
        public Nullable<int> PROD_IN_OPCAO_COMBO { get; set; }
        public Nullable<int> PROD_IN_DIVISAO { get; set; }
        public Nullable<int> PROD_NR_VALIDADE { get; set; }
        public Nullable<int> PROD_IN_COBRAR_MAIOR { get; set; }
        public string PROD_DS_INFORMACAO_NUTRICIONAL { get; set; }
        public Nullable<int> PROD_IN_GERAR_ARQUIVO { get; set; }
        public string PROD_NR_NCM { get; set; }
        public string PROD_NM_ORIGEM { get; set; }
        public string PROD_CD_GTIN_EAN { get; set; }
        public string PROD_NM_LOCALIZACAO_ESTOQUE { get; set; }
        public Nullable<decimal> PROD_QN_PESO_BRUTO { get; set; }
        public Nullable<decimal> PROD_QN_PESO_LIQUIDO { get; set; }
        public Nullable<int> PROD_IN_TIPO_EMBALAGEM { get; set; }
        public Nullable<decimal> PROD_NR_LARGURA { get; set; }
        public Nullable<decimal> PROD_NR_COMPRIMENTO { get; set; }
        public Nullable<decimal> PROD_NR_ALTURA { get; set; }
        public Nullable<decimal> PROD_NR_DIAMETRO { get; set; }
        public Nullable<decimal> PROD_VL_CUSTO { get; set; }
        public Nullable<decimal> PROD_PC_MARKUP_MININO { get; set; }
        public Nullable<decimal> PROD_VL_PRECO_MINIMO { get; set; }
        public Nullable<decimal> PROD_VL_MARKUP_PADRAO { get; set; }
        public string PROD_TX_OBSERVACOES { get; set; }
        public Nullable<int> PROD_IN_COMPOSTO { get; set; }
        public string PROD_NM_MARCA { get; set; }
        public string PROD_NM_MODELO { get; set; }
        public string PROD_NM_REFERENCIA_FABRICANTE { get; set; }
        public string PROD_NM_FABRICANTE { get; set; }
        public string PROD_NR_BARCODE { get; set; }
        public string PROD_QR_QRCODE { get; set; }
        public string PROD_NR_CEST { get; set; }
        public string PROD_NR_GTIN_EAN_TRIB { get; set; }
        public string PROD_NM_UNIDADE_TRIB { get; set; }
        public string PROD_NR_FATOR_CONVERSAO { get; set; }
        public string PROD_NR_ENQUADRE_IPI { get; set; }
        public Nullable<decimal> PROD_VL_IPI_FIXO { get; set; }
        public string PROD_NM_SLUG { get; set; }
        public string PROD_NM_KEYWORDS { get; set; }
        public string PROD_NM_TITULO_SEO { get; set; }
        public string PROD_DS_DESCRICAO_CEO { get; set; }
        public string PROD_NR_TAG { get; set; }
        public Nullable<decimal> PRTP_VL_PRECO { get; set; }
        public Nullable<decimal> PRTP_VL_PRECO_PROMOCAO { get; set; }
        public Nullable<decimal> PRTP_VL_DESCONTO_MAXIMO { get; set; }
        public string PROD_DS_JUSTIFICATIVA { get; set; }
        public Nullable<int> PROD_QN_NOVA_CONTAGEM { get; set; }
        public Nullable<int> PROD_QN_CONTAGEM { get; set; }
        public Nullable<decimal> PRTP_VL_CUSTO { get; set; }
        public Nullable<int> PROD_IN_KIT { get; set; }
    
        public virtual ASSINANTE ASSINANTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATENDIMENTO> ATENDIMENTO { get; set; }
        public virtual CATEGORIA_PRODUTO CATEGORIA_PRODUTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FICHA_TECNICA> FICHA_TECNICA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FICHA_TECNICA_DETALHE> FICHA_TECNICA_DETALHE { get; set; }
        public virtual FILIAL FILIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_PEDIDO_COMPRA> ITEM_PEDIDO_COMPRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_PEDIDO_VENDA> ITEM_PEDIDO_VENDA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOVIMENTO_ESTOQUE_PRODUTO> MOVIMENTO_ESTOQUE_PRODUTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEM_SERVICO> ORDEM_SERVICO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEM_SERVICO_PRODUTO> ORDEM_SERVICO_PRODUTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRECO_PRODUTO> PRECO_PRODUTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_ANEXO> PRODUTO_ANEXO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_BARCODE> PRODUTO_BARCODE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_ESTOQUE_FILIAL> PRODUTO_ESTOQUE_FILIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_FORNECEDOR> PRODUTO_FORNECEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_GRADE> PRODUTO_GRADE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_KIT> PRODUTO_KIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_KIT> PRODUTO_KIT1 { get; set; }
        public virtual PRODUTO_ORIGEM PRODUTO_ORIGEM { get; set; }
        public virtual SUBCATEGORIA_PRODUTO SUBCATEGORIA_PRODUTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_TABELA_PRECO> PRODUTO_TABELA_PRECO { get; set; }
        public virtual UNIDADE UNIDADE { get; set; }
    }
}
