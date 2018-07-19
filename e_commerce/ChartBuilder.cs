using Entity;
using Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class ChartBuilder
    {
        List<Product> productList;
        List<ChartItem> itemList;
        ProductRepository PR;
        CheckoutDetails cd;

        List<CheckoutDetails> cdList=new List<CheckoutDetails>();
        public ChartBuilder(List<Product> LP, List<ChartItem> CI)
        {
            productList = LP;
            itemList = CI;
        }

        public List<CheckoutDetails> FormCheckoutPage()
        {            

            foreach(var item in itemList)
            {
                cd = new CheckoutDetails();

                cd.Item = item.Item;
                cd.Quantity = item.Quantity;

                PR = new ProductRepository(productList.Where(x => x.Name == item.Item).Single(), item);
                cd.Total = PR.TotalPriceBasedUponPromotionLogic();

                cd.PromotionApplied = productList.Where(x => x.Name == item.Item).Single().Promotion.ToString();
                cd.Price = productList.Where(x => x.Name == item.Item).Single().Price.ToString();

                cdList.Add(cd);
            }
            return cdList;
        }
    }
}
