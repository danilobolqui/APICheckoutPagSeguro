using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedCode.PagSeguro
{
    public enum StatusTransacaoEnum
    {
        /// <summary>
        /// Quando não existe nenhum transação no retorno do PagSeguro.
        /// </summary>
        NaoExisteTransacao = 0,
        /// <summary>
        /// O comprador iniciou a transação, mas até o momento o PagSeguro não recebeu nenhuma informação sobre o pagamento.
        /// </summary>
        AguardandoPagamento = 1,
        /// <summary>
        /// O comprador optou por pagar com um cartão de crédito e o PagSeguro está analisando o risco da transação.
        /// </summary>
        EmAnalise = 2,
        /// <summary>
        /// A transação foi paga pelo comprador e o PagSeguro já recebeu uma confirmação da instituição financeira responsável pelo processamento.
        /// </summary>
        Paga = 3,
        /// <summary>
        /// A transação foi paga e chegou ao final de seu prazo de liberação sem ter sido retornada e sem que haja nenhuma disputa aberta.
        /// </summary>
        Disponivel = 4,
        /// <summary>
        /// O comprador, dentro do prazo de liberação da transação, abriu uma disputa.
        /// </summary>
        EmDisputa = 5,
        /// <summary>
        /// O valor da transação foi devolvido para o comprador.
        /// </summary>
        Devolvida = 6,
        /// <summary>
        /// A transação foi cancelada sem ter sido finalizada.
        /// </summary>
        Cancelada = 7,
        /// <summary>
        /// O valor da transação foi devolvido para o comprador.
        /// </summary>
        Debitado = 8,
        /// <summary>
        /// O comprador abriu uma solicitação de chargeback junto à operadora do cartão de crédito.
        /// </summary>
        RetencaoTemporaria = 9
    }

    public enum TipoPagamentoEnum
    {
        /// <summary>
        /// O comprador escolheu pagar a transação com cartão de crédito.
        /// </summary>
        CartaoDeCredito = 1,
        /// <summary>
        /// O comprador optou por pagar com um boleto bancário.
        /// </summary>
        Boleto = 2,
        /// <summary>
        /// (TEF): O comprador optou por pagar a transação com débito online de algum dos bancos conveniados.
        /// </summary>
        DebitoOnLineTEF = 3,
        /// <summary>
        /// O comprador optou por pagar a transação utilizando o saldo de sua conta PagSeguro.
        /// </summary>
        SaldoPagSeguro = 4,
        /// <summary>
        /// O comprador escolheu pagar sua transação através de seu celular Oi. 
        /// </summary>
        OiPago = 5,
        /// <summary>
        /// Depósito em conta.
        /// </summary>
        DepositoEmConta = 7
    }
}