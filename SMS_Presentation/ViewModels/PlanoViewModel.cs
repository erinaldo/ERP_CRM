using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EntitiesServices.Model;

namespace ERP_CRM_Solution.ViewModels
{
    public class PlanoViewModel
    {
        [Key]
        public int PLAN_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo NOME obrigatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O NOME deve conter no minimo 2 e no m�ximo 50 caracteres.")]
        public string PLAN_NM_NOME { get; set; }
        [Required(ErrorMessage = "Campo DATA DE CRIA��O obrigatorio")]
        [DataType(DataType.Date, ErrorMessage = "A DATA DE CRIA��O deve ser uma data v�lida")]
        public Nullable<System.DateTime> PLAN_DT_CRIACAO { get; set; }
        public Nullable<int> PLAN_IN_ATIVO { get; set; }
        [Required(ErrorMessage = "Campo DESCRI��O obrigatorio")]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "A DESCRI��O deve conter no minimo 2 e no m�ximo 500 caracteres.")]
        public string PLAN_DS_DESCRICAO { get; set; }
        [Required(ErrorMessage = "Campo N�MERO DE USU�RIOS ATIVOS obrigatorio")]
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_USUARIOS { get; set; }
        [Required(ErrorMessage = "Campo N�MERO DE CONTATOS ATIVOS obrigatorio")]
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_CONTATOS { get; set; }
        [Required(ErrorMessage = "Campo N�MERO DE E-MAILS/M�S obrigatorio")]
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_EMAIL { get; set; }
        [Required(ErrorMessage = "Campo N�MERO DE SMS/M�S obrigatorio")]
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_SMS { get; set; }
        [Required(ErrorMessage = "Campo N�MERO DE WHATSAPP/M�S obrigatorio")]
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_WHATSAPP { get; set; }
        [Required(ErrorMessage = "Campo N�MERO DE PROCESSOS ATIVOS obrigatorio")]
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_PROCESSOS { get; set; }
        [Required(ErrorMessage = "Campo N�MERO DE A��ES ATIVAS obrigatorio")]
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_ACOES { get; set; }
        [Required(ErrorMessage = "Campo PRE�O obrigatorio")]
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<decimal> PLAN_VL_PRECO { get; set; }
        [Required(ErrorMessage = "Campo PERIODICIDADE obrigatorio")]
        public Nullable<int> PLPE_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo DATA DE VALIDADE obrigatorio")]
        [DataType(DataType.Date, ErrorMessage = "A DATA DE VALIDADE deve ser uma data v�lida")]
        public Nullable<System.DateTime> PLAN_DT_VALIDADE { get; set; }
        [Required(ErrorMessage = "Campo PRE�O PROMO��O obrigatorio")]
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
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
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_PATRIMONIO { get; set; }
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_PRODUTO { get; set; }
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_FORNECEDOR { get; set; }
        public Nullable<int> PLAN_IN_VENDAS { get; set; }
        public Nullable<int> PLAN_IN_COMPRA { get; set; }
        public Nullable<int> PLAN_IN_SERVICOS { get; set; }
        public Nullable<int> PLAN_IN_ATENDIMENTOS { get; set; }
        public Nullable<int> PLAN_IN_OS { get; set; }
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_COMPRA { get; set; }
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor num�rico positivo")]
        public Nullable<int> PLAN_NR_VENDA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSINANTE> ASSINANTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSINANTE_PAGAMENTO> ASSINANTE_PAGAMENTO { get; set; }
        public virtual PLANO_PERIODICIDADE PLANO_PERIODICIDADE { get; set; }

    }
}