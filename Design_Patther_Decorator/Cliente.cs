using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patther_Decorator
{
    public class Cliente
    {
        private IFormaPagamento _formaPagamento;

        public void SetFormaPagamento(IFormaPagamento formaPagamento)
        {
            _formaPagamento = formaPagamento;
        }

        public void RealizarPagamento(double valor)
        {
            _formaPagamento.RealizarPagamento(valor);
        }
    }
}
