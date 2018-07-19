using Entity;
using Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class Program
    {
        static void Main(string[] args)
        {
            Initilizer I = new Initilizer();
            I.PopulateProductItems();
            I.BuildChart();

            ChartBuilder cb = new ChartBuilder(I.PopulateProductItems(), I.BuildChart());
            List<CheckoutDetails> list= cb.FormCheckoutPage();
            

            int checkoutTotalpayable= calculateTotalAmount(list); 
            Console.WriteLine("Payable: {0}", checkoutTotalpayable);
            Console.ReadLine();
        }
        public static int calculateTotalAmount(List<CheckoutDetails> list)
        {
            int checkoutTotalpayable = 0;

            foreach (var item in list)
            {
                Console.WriteLine("Item: {0}, Quantity: {1}, Price: {2}, Total: {3}, Promotion Applied: {4}", item.Item, item.Quantity, item.Price, item.Total, item.PromotionApplied);
                checkoutTotalpayable += item.Total;
            }
            return checkoutTotalpayable;
        }        
    }   
}
