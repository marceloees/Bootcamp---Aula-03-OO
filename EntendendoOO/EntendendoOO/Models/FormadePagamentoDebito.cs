using System;
using System.Collections.Generic;
using System.Text;

namespace EntendendoOO.Models.FormadePagamento
{
    class FormadePagamentoCredito : FormadePagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento com cartão de crédito");
        }
    }
}
