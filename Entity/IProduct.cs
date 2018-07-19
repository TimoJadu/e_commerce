using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface IProduct
    {
        int id { get; set; }
        string Name { get; set; }
        int Price { get; set; }
        Promotions Promotion { get; set; }
    }
}
