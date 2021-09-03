using System;
using System.Collections.Generic;
using System.Text;

namespace EntendendoOO.Models.FormadePagamento
{
    class FormadePagamentoDebito : FormadePagamentoCartao
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento com cartão de crédito");
        }
    }
}
