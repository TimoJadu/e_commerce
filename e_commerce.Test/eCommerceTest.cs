using Entity;
using NUnit.Framework;
using Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce;

namespace e_commerce.Test
{
    [TestFixture]
    public class eCommerceTest
    {
        static IChartItem c1 = new ChartItem
        {
            Item = "A",
            Quantity = 2
        };
        static IProduct p1 = new Product
        {
            id = 1,
            Name = "A",
            Price = 20,
            Promotion = Promotions.Buy1Get1Free
        };
        ProductRepository pr = new ProductRepository(p1, c1);

        [Test]
        public void SampleTest()
        {
            Assert.Pass();
        }

        [Test]
        public void ProductTest()
        {    
            Assert.AreEqual(p1.id, 1);
            Assert.AreEqual(p1.Name, "A");
            Assert.AreEqual(p1.Price, 20);
            Assert.AreEqual(p1.Promotion, Promotions.Buy1Get1Free);
        }

        [Test]
        public void ChartItemTest()
        {
            

            Assert.AreEqual(c1.Item, "A");
            Assert.AreEqual(c1.Quantity, 2);            
        }
        [Test]
        public void ProductRepositoryTest()
        {
            pr.TotalPriceBasedUponPromotionLogic();
            Assert.AreEqual(pr.TotalPriceBasedUponPromotionLogic(), 20);
        }
        [Test]
        public void TotalPayableAmountTest()
        {
            Initilizer I = new Initilizer();
            I.PopulateProductItems();
            I.BuildChart();

            ChartBuilder cb = new ChartBuilder(I.PopulateProductItems(), I.BuildChart());
            List<CheckoutDetails> list = cb.FormCheckoutPage();

            
            Program.calculateTotalAmount(list);
            
            Assert.AreEqual(Program.calculateTotalAmount(list), 48);
        }

        static IChartItem c2 = new ChartItem
        {
            Item = "A",
            Quantity = 3
        };
        static IProduct p2 = new Product
        {
            id = 1,
            Name = "A",
            Price = 20,
            Promotion = Promotions.Buy1Get1Free
        };
        ProductRepository pr2 = new ProductRepository(p2, c2);

        

        static IChartItem c3 = new ChartItem
        {
            Item = "A",
            Quantity = 5
        };
        static IProduct p3 = new Product
        {
            id = 1,
            Name = "A",
            Price = 4,
            Promotion = Promotions._3for10Euros
        };
        ProductRepository pr3 = new ProductRepository(p3, c3);

        static IChartItem c4 = new ChartItem
        {
            Item = "A",
            Quantity = 7
        };
        static IProduct p4 = new Product
        {
            id = 1,
            Name = "A",
            Price = 4,
            Promotion = Promotions.Nothing
        };
        ProductRepository pr4 = new ProductRepository(p4, c4);

        [Test]
        public void TotalPriceBasedUponPromotionLogicTest()
        {
            Assert.AreEqual(pr2.TotalPriceBasedUponPromotionLogic(), 20);

            Assert.AreEqual(pr3.TotalPriceBasedUponPromotionLogic(), 18);

            Assert.AreEqual(pr4.TotalPriceBasedUponPromotionLogic(), 28);
        }
    }
}
