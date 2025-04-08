using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStorage
{
    public class InvoiceItem
    {
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public override string ToString()
        {
            return $"{ItemName} ({Quantity})\n{ItemDescription}\n{TotalPrice:0.00}";
        }
    }
}
