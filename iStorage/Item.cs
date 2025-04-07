using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStorage
{
    public class Item
    {
        public string ItemName { get; set; }
        public int? ImageID { get; set; }
        public string ItemDescription { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{ItemName} \n {ItemDescription} \n {Price:0.00}€";
        }
    }
}
