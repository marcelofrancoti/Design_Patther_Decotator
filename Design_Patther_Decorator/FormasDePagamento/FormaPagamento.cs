using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patther_Decorator.FormasDePagamento
{
    public class FormaPagamento : IFormaPagamento
    {
        public virtual void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor} realizado com a forma de pagamento base.");
        }
    }
}
