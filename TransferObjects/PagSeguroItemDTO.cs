using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedCode.PagSeguro.TransferObjects
{
    public class PagSeguroItemDTO
    {
        public string itemId { get; set; }
        public string itemDescription { get; set; }
        public string itemAmount { get; set; }
        public string itemQuantity { get; set; }
        public string itemWeight { get; set; }
    }
}
