using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedCode.PagSeguro.TransferObjects
{
    public class ConsultaTransacaoPagSeguroTransactionDTO
    {
        public DateTime Date { get; set; }
        public string Reference { get; set; }
        public string Code { get; set; }
        public int type { get; set; }
        public int Status { get; set; }
        public int PaymentMethodType { get; set; }
        public double GrossAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double FeeAmount { get; set; }
        public double NetAmount { get; set; }
        public double ExtraAmount { get; set; }
        public DateTime LastEventDate { get; set; }
    }
}
