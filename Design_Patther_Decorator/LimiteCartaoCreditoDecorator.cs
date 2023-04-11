using Design_Patther_Decorator.FormasDePagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patther_Decorator
{
    public class LimiteCartaoCreditoDecorator : FormaPagamentoDecorator
    {
        private double _limite;

        public LimiteCartaoCreditoDecorator(IFormaPagamento formaPagamento, double limite) : base(formaPagamento)
        {
            _limite = limite;
        }

        public override void RealizarPagamento(double valor)
        {
            if (valor <= _limite)
            {
                Console.WriteLine($"Pagamento de R${valor} realizado com Cartão de Crédito.");
            }
            else
            {
                Console.WriteLine($"Pagamento de R${valor} excedeu o limite para Cartão de Crédito. Processando com próxima forma de pagamento...");
                base.RealizarPagamento(valor);
            }
        }
    }
}
