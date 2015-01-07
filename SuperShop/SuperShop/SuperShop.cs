using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop
{
    class SuperShop
    {
        public string SuperShopName { get; set; }
        public string Address { get; set; }
        private Dictionary<int, Product> products;
        public SuperShop(string superShop, string address):this()
        {
            SuperShopName = superShop;
            Address = address;
        }

        public SuperShop()
        {
            products = new Dictionary<int, Product>();
        }

        public string AddItem(Product anProduct )
        {
            if (products.ContainsKey(anProduct.ProductId))
            {
                products[anProduct.ProductId] = anProduct;
                return "updated SuccessFully";
            }
            else
            {
                  products.Add(anProduct.ProductId, anProduct);
                return "Add SuccessFully";
            }
        }
    }
}
