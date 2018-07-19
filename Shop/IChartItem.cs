using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public interface IChartItem
    {
         string Item { get; set; }
        int Quantity { get; set; }
    }
}
