using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket_SecondLAB
{
    internal class Product
    {
        public string Name { get; set; }
        public string Supplier { get; set; }
        public DateTime Expiry { get; set; }
        public DateTime Entry { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
        public int Unit { get; set; }
    }
}
