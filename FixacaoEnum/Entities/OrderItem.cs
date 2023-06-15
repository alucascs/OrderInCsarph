using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoEnum.Entities
{
    internal class OrderItem
    {
        public int Quantily { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantily, double price, Product product)
        {
            Quantily = quantily;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantily;
        }

        public override string ToString()
        {
            return Product.Name
                 + ", $"
                 + Price.ToString("F2", CultureInfo.InvariantCulture)
                 + ", Quantity: "
                 + Quantily
                 + ", Subtotal: $"
                 + SubTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
