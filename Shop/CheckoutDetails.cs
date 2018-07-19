using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class CheckoutDetails: ICheckoutDetails
    {
        public string Item { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public int Total { get; set; }
        public string PromotionApplied { get; set; }        
    }
}
