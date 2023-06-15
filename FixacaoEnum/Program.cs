using FixacaoEnum.Entities;
using FixacaoEnum.Entities.Enum;
using System;
using System.Globalization;

namespace FixacaoEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Enter order status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string pname = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(pname, price);

                Console.Write("Quantily: ");
                int quant = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quant, price, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order Sumary: ");
            Console.WriteLine(order);
        }
    }
}