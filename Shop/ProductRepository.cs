using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ProductRepository : IPromotion
    {
        IProduct prod;
        IChartItem ci;
        public ProductRepository(IProduct p, IChartItem CI)
        {
            prod = p;
            ci = CI;
        }
        public int TotalPriceBasedUponPromotionLogic()
        {
            if (this.prod.Promotion == Promotions.Buy1Get1Free)
            {
                if (this.ci.Quantity > 1)
                {
                    return (int)Math.Truncate((double)(this.ci.Quantity / 2)) * this.prod.Price;
                }
                else
                    return this.ci.Quantity * this.prod.Price;
            }
            else if(this.prod.Promotion == Promotions._3for10Euros)
            {
                if (this.ci.Quantity % 3==0 && this.ci.Quantity>0)
                {
                    return (this.ci.Quantity / 3) * 10;
                }
                else if (this.ci.Quantity > 3)
                {
                    return (this.ci.Quantity % 3) * this.prod.Price + (int)(this.ci.Quantity / 3) * 10;
                }
                else
                {
                    return this.ci.Quantity * this.prod.Price;
                }
            }
            else
            {
                return this.ci.Quantity * this.prod.Price;
            }            
        }
    }
}
