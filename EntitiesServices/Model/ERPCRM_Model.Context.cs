﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERP_CRMEntities : DbContext
    {
        public ERP_CRMEntities()
            : base("name=ERP_CRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AGENDA> AGENDA { get; set; }
        public virtual DbSet<AGENDA_ANEXO> AGENDA_ANEXO { get; set; }
        public virtual DbSet<AGENDA_VINCULO> AGENDA_VINCULO { get; set; }
        public virtual DbSet<ASSINANTE> ASSINANTE { get; set; }
        public virtual DbSet<ASSINANTE_ANEXO> ASSINANTE_ANEXO { get; set; }
        public virtual DbSet<ASSINANTE_CONSUMO> ASSINANTE_CONSUMO { get; set; }
        public virtual DbSet<ASSINANTE_PAGAMENTO> ASSINANTE_PAGAMENTO { get; set; }
        public virtual DbSet<ASSINANTE_PLANO> ASSINANTE_PLANO { get; set; }
        public virtual DbSet<ASSINANTE_QUADRO_SOCIETARIO> ASSINANTE_QUADRO_SOCIETARIO { get; set; }
        public virtual DbSet<ATENDIMENTO> ATENDIMENTO { get; set; }
        public virtual DbSet<ATENDIMENTO_ACOMPANHAMENTO> ATENDIMENTO_ACOMPANHAMENTO { get; set; }
        public virtual DbSet<ATENDIMENTO_AGENDA> ATENDIMENTO_AGENDA { get; set; }
        public virtual DbSet<ATENDIMENTO_ANEXO> ATENDIMENTO_ANEXO { get; set; }
        public virtual DbSet<BANCO> BANCO { get; set; }
        public virtual DbSet<CARGO> CARGO { get; set; }
        public virtual DbSet<CATEGORIA_AGENDA> CATEGORIA_AGENDA { get; set; }
        public virtual DbSet<CATEGORIA_ATENDIMENTO> CATEGORIA_ATENDIMENTO { get; set; }
        public virtual DbSet<CATEGORIA_CLIENTE> CATEGORIA_CLIENTE { get; set; }
        public virtual DbSet<CATEGORIA_EQUIPAMENTO> CATEGORIA_EQUIPAMENTO { get; set; }
        public virtual DbSet<CATEGORIA_FORNECEDOR> CATEGORIA_FORNECEDOR { get; set; }
        public virtual DbSet<CATEGORIA_NOTIFICACAO> CATEGORIA_NOTIFICACAO { get; set; }
        public virtual DbSet<CATEGORIA_ORDEM_SERVICO> CATEGORIA_ORDEM_SERVICO { get; set; }
        public virtual DbSet<CATEGORIA_PRODUTO> CATEGORIA_PRODUTO { get; set; }
        public virtual DbSet<CATEGORIA_SERVICO> CATEGORIA_SERVICO { get; set; }
        public virtual DbSet<CATEGORIA_TELEFONE> CATEGORIA_TELEFONE { get; set; }
        public virtual DbSet<CATEGORIA_USUARIO> CATEGORIA_USUARIO { get; set; }
        public virtual DbSet<CENTRO_CUSTO> CENTRO_CUSTO { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<CLIENTE_ANEXO> CLIENTE_ANEXO { get; set; }
        public virtual DbSet<CLIENTE_CONTATO> CLIENTE_CONTATO { get; set; }
        public virtual DbSet<CLIENTE_NEW> CLIENTE_NEW { get; set; }
        public virtual DbSet<CLIENTE_QUADRO_SOCIETARIO> CLIENTE_QUADRO_SOCIETARIO { get; set; }
        public virtual DbSet<CLIENTE_REFERENCIA> CLIENTE_REFERENCIA { get; set; }
        public virtual DbSet<CLIENTE_TAG> CLIENTE_TAG { get; set; }
        public virtual DbSet<CONFIGURACAO> CONFIGURACAO { get; set; }
        public virtual DbSet<CONTA_BANCO> CONTA_BANCO { get; set; }
        public virtual DbSet<CONTA_BANCO_CONTATO> CONTA_BANCO_CONTATO { get; set; }
        public virtual DbSet<CONTA_BANCO_LANCAMENTO> CONTA_BANCO_LANCAMENTO { get; set; }
        public virtual DbSet<CONTA_PAGAR> CONTA_PAGAR { get; set; }
        public virtual DbSet<CONTA_PAGAR_ANEXO> CONTA_PAGAR_ANEXO { get; set; }
        public virtual DbSet<CONTA_PAGAR_PARCELA> CONTA_PAGAR_PARCELA { get; set; }
        public virtual DbSet<CONTA_PAGAR_RATEIO> CONTA_PAGAR_RATEIO { get; set; }
        public virtual DbSet<CONTA_RECEBER> CONTA_RECEBER { get; set; }
        public virtual DbSet<CONTA_RECEBER_ANEXO> CONTA_RECEBER_ANEXO { get; set; }
        public virtual DbSet<CONTA_RECEBER_PARCELA> CONTA_RECEBER_PARCELA { get; set; }
        public virtual DbSet<CONTA_RECEBER_RATEIO> CONTA_RECEBER_RATEIO { get; set; }
        public virtual DbSet<CRM> CRM { get; set; }
        public virtual DbSet<CRM_ACAO> CRM_ACAO { get; set; }
        public virtual DbSet<CRM_ANEXO> CRM_ANEXO { get; set; }
        public virtual DbSet<CRM_COMENTARIO> CRM_COMENTARIO { get; set; }
        public virtual DbSet<CRM_CONTATO> CRM_CONTATO { get; set; }
        public virtual DbSet<CRM_ORIGEM> CRM_ORIGEM { get; set; }
        public virtual DbSet<DEPARTAMENTO> DEPARTAMENTO { get; set; }
        public virtual DbSet<EMAIL_AGENDAMENTO> EMAIL_AGENDAMENTO { get; set; }
        public virtual DbSet<EQUIPAMENTO> EQUIPAMENTO { get; set; }
        public virtual DbSet<EQUIPAMENTO_ANEXO> EQUIPAMENTO_ANEXO { get; set; }
        public virtual DbSet<EQUIPAMENTO_MANUTENCAO> EQUIPAMENTO_MANUTENCAO { get; set; }
        public virtual DbSet<FICHA_TECNICA> FICHA_TECNICA { get; set; }
        public virtual DbSet<FICHA_TECNICA_DETALHE> FICHA_TECNICA_DETALHE { get; set; }
        public virtual DbSet<FILIAL> FILIAL { get; set; }
        public virtual DbSet<FORMA_ENVIO> FORMA_ENVIO { get; set; }
        public virtual DbSet<FORMA_FRETE> FORMA_FRETE { get; set; }
        public virtual DbSet<FORMA_PAGAMENTO> FORMA_PAGAMENTO { get; set; }
        public virtual DbSet<FORMULARIO_RESPOSTA> FORMULARIO_RESPOSTA { get; set; }
        public virtual DbSet<FORNECEDOR> FORNECEDOR { get; set; }
        public virtual DbSet<FORNECEDOR_ANEXO> FORNECEDOR_ANEXO { get; set; }
        public virtual DbSet<FORNECEDOR_COMENTARIO> FORNECEDOR_COMENTARIO { get; set; }
        public virtual DbSet<FORNECEDOR_CONTATO> FORNECEDOR_CONTATO { get; set; }
        public virtual DbSet<FORNECEDOR_MENSAGEM> FORNECEDOR_MENSAGEM { get; set; }
        public virtual DbSet<FORNECEDOR_QUADRO_SOCIETARIO> FORNECEDOR_QUADRO_SOCIETARIO { get; set; }
        public virtual DbSet<GRUPO> GRUPO { get; set; }
        public virtual DbSet<GRUPO_CC> GRUPO_CC { get; set; }
        public virtual DbSet<GRUPO_CLIENTE> GRUPO_CLIENTE { get; set; }
        public virtual DbSet<ITEM_PEDIDO_COMPRA> ITEM_PEDIDO_COMPRA { get; set; }
        public virtual DbSet<ITEM_PEDIDO_VENDA> ITEM_PEDIDO_VENDA { get; set; }
        public virtual DbSet<LOG> LOG { get; set; }
        public virtual DbSet<MENSAGEM_ANEXO> MENSAGEM_ANEXO { get; set; }
        public virtual DbSet<MENSAGEM_AUTOMACAO> MENSAGEM_AUTOMACAO { get; set; }
        public virtual DbSet<MENSAGEM_AUTOMACAO_DATAS> MENSAGEM_AUTOMACAO_DATAS { get; set; }
        public virtual DbSet<MENSAGENS> MENSAGENS { get; set; }
        public virtual DbSet<MENSAGENS_DESTINOS> MENSAGENS_DESTINOS { get; set; }
        public virtual DbSet<MOTIVO_CANCELAMENTO> MOTIVO_CANCELAMENTO { get; set; }
        public virtual DbSet<MOTIVO_ENCERRAMENTO> MOTIVO_ENCERRAMENTO { get; set; }
        public virtual DbSet<MOVIMENTO_ESTOQUE_PRODUTO> MOVIMENTO_ESTOQUE_PRODUTO { get; set; }
        public virtual DbSet<NOMENCLATURA_BRAS_SERVICOS> NOMENCLATURA_BRAS_SERVICOS { get; set; }
        public virtual DbSet<NOTICIA> NOTICIA { get; set; }
        public virtual DbSet<NOTICIA_COMENTARIO> NOTICIA_COMENTARIO { get; set; }
        public virtual DbSet<NOTIFICACAO> NOTIFICACAO { get; set; }
        public virtual DbSet<NOTIFICACAO_ANEXO> NOTIFICACAO_ANEXO { get; set; }
        public virtual DbSet<ORDEM_SERVICO> ORDEM_SERVICO { get; set; }
        public virtual DbSet<ORDEM_SERVICO_ACOMPANHAMENTO> ORDEM_SERVICO_ACOMPANHAMENTO { get; set; }
        public virtual DbSet<ORDEM_SERVICO_AGENDA> ORDEM_SERVICO_AGENDA { get; set; }
        public virtual DbSet<ORDEM_SERVICO_ANEXO> ORDEM_SERVICO_ANEXO { get; set; }
        public virtual DbSet<ORDEM_SERVICO_COMENTARIOS> ORDEM_SERVICO_COMENTARIOS { get; set; }
        public virtual DbSet<ORDEM_SERVICO_PRODUTO> ORDEM_SERVICO_PRODUTO { get; set; }
        public virtual DbSet<ORDEM_SERVICO_SERVICO> ORDEM_SERVICO_SERVICO { get; set; }
        public virtual DbSet<PEDIDO_COMPRA> PEDIDO_COMPRA { get; set; }
        public virtual DbSet<PEDIDO_COMPRA_ACOMPANHAMENTO> PEDIDO_COMPRA_ACOMPANHAMENTO { get; set; }
        public virtual DbSet<PEDIDO_COMPRA_ANEXO> PEDIDO_COMPRA_ANEXO { get; set; }
        public virtual DbSet<PEDIDO_VENDA> PEDIDO_VENDA { get; set; }
        public virtual DbSet<PEDIDO_VENDA_ACOMPANHAMENTO> PEDIDO_VENDA_ACOMPANHAMENTO { get; set; }
        public virtual DbSet<PEDIDO_VENDA_ANEXO> PEDIDO_VENDA_ANEXO { get; set; }
        public virtual DbSet<PEDIDO_VENDA_PARCELA> PEDIDO_VENDA_PARCELA { get; set; }
        public virtual DbSet<PERFIL> PERFIL { get; set; }
        public virtual DbSet<PERIODICIDADE> PERIODICIDADE { get; set; }
        public virtual DbSet<PERIODICIDADE_TAREFA> PERIODICIDADE_TAREFA { get; set; }
        public virtual DbSet<PLANO> PLANO { get; set; }
        public virtual DbSet<PLANO_PERIODICIDADE> PLANO_PERIODICIDADE { get; set; }
        public virtual DbSet<POSICAO> POSICAO { get; set; }
        public virtual DbSet<PRECO_PRODUTO> PRECO_PRODUTO { get; set; }
        public virtual DbSet<PRODUTO> PRODUTO { get; set; }
        public virtual DbSet<PRODUTO_ANEXO> PRODUTO_ANEXO { get; set; }
        public virtual DbSet<PRODUTO_BARCODE> PRODUTO_BARCODE { get; set; }
        public virtual DbSet<PRODUTO_ESTOQUE_FILIAL> PRODUTO_ESTOQUE_FILIAL { get; set; }
        public virtual DbSet<PRODUTO_FORNECEDOR> PRODUTO_FORNECEDOR { get; set; }
        public virtual DbSet<PRODUTO_GRADE> PRODUTO_GRADE { get; set; }
        public virtual DbSet<PRODUTO_KIT> PRODUTO_KIT { get; set; }
        public virtual DbSet<PRODUTO_ORIGEM> PRODUTO_ORIGEM { get; set; }
        public virtual DbSet<PRODUTO_TABELA_PRECO> PRODUTO_TABELA_PRECO { get; set; }
        public virtual DbSet<REGIME_TRIBUTARIO> REGIME_TRIBUTARIO { get; set; }
        public virtual DbSet<RESUMO_VENDA> RESUMO_VENDA { get; set; }
        public virtual DbSet<SERVICO> SERVICO { get; set; }
        public virtual DbSet<SERVICO_ANEXO> SERVICO_ANEXO { get; set; }
        public virtual DbSet<SERVICO_TABELA_PRECO> SERVICO_TABELA_PRECO { get; set; }
        public virtual DbSet<SEXO> SEXO { get; set; }
        public virtual DbSet<SUBCATEGORIA_PRODUTO> SUBCATEGORIA_PRODUTO { get; set; }
        public virtual DbSet<SUBGRUPO> SUBGRUPO { get; set; }
        public virtual DbSet<TAMANHO> TAMANHO { get; set; }
        public virtual DbSet<TAREFA> TAREFA { get; set; }
        public virtual DbSet<TAREFA_ACOMPANHAMENTO> TAREFA_ACOMPANHAMENTO { get; set; }
        public virtual DbSet<TAREFA_ANEXO> TAREFA_ANEXO { get; set; }
        public virtual DbSet<TAREFA_NOTIFICACAO> TAREFA_NOTIFICACAO { get; set; }
        public virtual DbSet<TAREFA_VINCULO> TAREFA_VINCULO { get; set; }
        public virtual DbSet<TELEFONE> TELEFONE { get; set; }
        public virtual DbSet<TEMPLATE> TEMPLATE { get; set; }
        public virtual DbSet<TEMPLATE_EMAIL> TEMPLATE_EMAIL { get; set; }
        public virtual DbSet<TEMPLATE_SMS> TEMPLATE_SMS { get; set; }
        public virtual DbSet<TIPO_ACAO> TIPO_ACAO { get; set; }
        public virtual DbSet<TIPO_CONTA> TIPO_CONTA { get; set; }
        public virtual DbSet<TIPO_CONTRIBUINTE> TIPO_CONTRIBUINTE { get; set; }
        public virtual DbSet<TIPO_CRM> TIPO_CRM { get; set; }
        public virtual DbSet<TIPO_GRUPO> TIPO_GRUPO { get; set; }
        public virtual DbSet<TIPO_PESSOA> TIPO_PESSOA { get; set; }
        public virtual DbSet<TIPO_TAREFA> TIPO_TAREFA { get; set; }
        public virtual DbSet<TIPO_TRANSPORTE> TIPO_TRANSPORTE { get; set; }
        public virtual DbSet<TIPO_VEICULO> TIPO_VEICULO { get; set; }
        public virtual DbSet<TRANSPORTADORA> TRANSPORTADORA { get; set; }
        public virtual DbSet<TRANSPORTADORA_ANEXO> TRANSPORTADORA_ANEXO { get; set; }
        public virtual DbSet<UF> UF { get; set; }
        public virtual DbSet<UNIDADE> UNIDADE { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<USUARIO_ANEXO> USUARIO_ANEXO { get; set; }
        public virtual DbSet<USUARIO_FUNCIONARIO> USUARIO_FUNCIONARIO { get; set; }
    }
}
