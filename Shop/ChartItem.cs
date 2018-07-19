using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ChartItem: IChartItem
    {
        public string Item { get; set; }
        public int Quantity { get; set; }
    }
}
