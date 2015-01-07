using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop
{
    class Product
    {
        public int ProductId { set; get; }
        public int Quantity { set; get; }

        public Product(int productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
