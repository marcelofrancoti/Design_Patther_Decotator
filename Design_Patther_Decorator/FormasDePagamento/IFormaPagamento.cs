using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patther_Decorator
{
    public interface IFormaPagamento
    {
        void RealizarPagamento(double valor);
    }

}
