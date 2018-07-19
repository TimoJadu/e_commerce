using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product: IProduct
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Price { get; set;}
        public Promotions Promotion { get; set; }
        
    }
}
