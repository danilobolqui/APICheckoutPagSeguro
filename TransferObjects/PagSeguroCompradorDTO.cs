using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedCode.PagSeguro.TransferObjects
{
    public class PagSeguroCompradorDTO
    {
        public string SenderName { get; set; }
        public string SenderAreaCode { get; set; }
        public string senderPhone { get; set; }
        public string senderEmail { get; set; }
    }
}