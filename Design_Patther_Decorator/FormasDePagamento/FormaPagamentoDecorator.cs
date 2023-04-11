using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patther_Decorator.FormasDePagamento
{
    public abstract class FormaPagamentoDecorator : IFormaPagamento
    {
        protected IFormaPagamento _formaPagamento;

        public FormaPagamentoDecorator(IFormaPagamento formaPagamento)
        {
            _formaPagamento = formaPagamento;
        }

        public virtual void RealizarPagamento(double valor)
        {
            _formaPagamento.RealizarPagamento(valor);
        }
    }
}
