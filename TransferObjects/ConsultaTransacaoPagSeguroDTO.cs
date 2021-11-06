using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedCode.PagSeguro.TransferObjects
{
    public class ConsultaTransacaoPagSeguroDTO
    {
        public DateTime Date { get; set; }
        public int ResultsInThisPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        public List<ConsultaTransacaoPagSeguroTransactionDTO> listTransaction { get; set;}
    }
}
