using Entity;
using Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
     public class Initilizer
    {
        public List<Product> PopulateProductItems()
        {
            var p1 = new Product
            {
                id = 1,
                Name = "A",
                Price = 20,
                Promotion = Promotions.Buy1Get1Free
            };

            var p2 = new Product
            {
                id = 2,
                Name = "B",
                Price = 4,
                Promotion = Promotions._3for10Euros
            };
            var p3 = new Product
            {
                id = 3,
                Name = "C",
                Price = 2,
                Promotion = Promotions.Nothing
            };
            var p4 = new Product
            {
                id = 4,
                Name = "D",
                Price = 4,
                Promotion = Promotions.Nothing
            };

            return new List<Product> { p1, p2, p3, p4 };
        }

        public List<ChartItem> BuildChart()
        {
            var c1 = new ChartItem
            {
                Item="A",
                Quantity=2
            };
            var c2 = new ChartItem
            {
                Item = "B",
                Quantity = 3
            };
            var c3 = new ChartItem
            {
                Item = "C",
                Quantity = 5
            };
            var c4 = new ChartItem
            {
                Item = "D",
                Quantity = 2
            };

            return new List<ChartItem> { c1, c2, c3, c4 };
        }
    }
}
