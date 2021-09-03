using System;
using System.Collections.Generic;
using System.Text;

namespace EntendendoOO.Models.FormadePagamento
{
    class FormadePagamentoVR : FormadePagamentoCartao
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento com cartão de crédito");
        }
    }
}
