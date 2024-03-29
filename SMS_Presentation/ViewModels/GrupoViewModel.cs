using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EntitiesServices.Model;

namespace ERP_CRM_Solution.ViewModels
{
    public class GrupoViewModel
    {
        [Key]
        public int GRUP_CD_ID { get; set; }
        public int ASSI_CD_ID { get; set; }
        public int USUA_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo NOME obrigatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O NOME deve conter no minimo 2 e no m�ximo 50 caracteres.")]
        public string GRUP_NM_NOME { get; set; }
        [DataType(DataType.Date, ErrorMessage = "A DATA DE CADASTRO deve ser uma data v�lida")]
        public System.DateTime GRUP_DT_CADASTRO { get; set; }
        public int GRUP_IN_ATIVO { get; set; }

        public Int32? SEXO { get; set; }
        public string NOME { get; set; }
        public Int32? ID { get; set; }
        public string CIDADE { get; set; }
        public Nullable<System.DateTime> DATA_NASC { get; set; }
        public Int32? UF { get; set; }
        public Int32? CATEGORIA { get; set; }
        public Int32? STATUS { get; set; }
        public String LINK { get; set; }
        public Int32? GRUPO { get; set; }
        public String MODELO { get; set; }
        public string DIA { get; set; }
        public string MES { get; set; }
        public string ANO { get; set; }

        public virtual ASSINANTE ASSINANTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO_CLIENTE> GRUPO_CLIENTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENSAGENS_DESTINOS> MENSAGENS_DESTINOS { get; set; }
    }
}