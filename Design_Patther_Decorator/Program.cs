using Design_Patther_Decorator.FormasDePagamento;
using System;

namespace Design_Patther_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configura o fluxo de pagamento
            IFormaPagamento formaPagamento = new FormaPagamento();
            formaPagamento = new LimiteCartaoCreditoDecorator(formaPagamento, 1000);
            formaPagamento = new LimitePayPalDecorator(formaPagamento, 2000);

            // Cliente realiza o pagamento
            Cliente cliente = new Cliente();
            cliente.SetFormaPagamento(formaPagamento);

            // Realiza o pagamento com diferentes valores
            cliente.RealizarPagamento(500); // Pagamento de R$500 realizado com Cartão de Crédito.
            cliente.RealizarPagamento(1500); // Pagamento de R$1500 excedeu o limite para Cartão de Crédito. Processando com próxima forma de pagamento...
                                             // Pagamento de R$1500 realizado com PayPal.
            cliente.RealizarPagamento(2500); // Pagamento de R$2500 excedeu o limite para PayPal. Processando com próxima forma de pagamento...
                                             // Pagamento de R$2500 realizado com a forma de pagamento base.
        }
    }
}
