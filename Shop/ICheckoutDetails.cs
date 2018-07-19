using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public interface ICheckoutDetails
    {
        string Item { get; set; }
        int Quantity { get; set; }
        string Price { get; set; }
        int Total { get; set; }
        string PromotionApplied { get; set; }
    }
}
