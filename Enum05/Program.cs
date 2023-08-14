using Enum05.Entities;
using Enum05.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status (Pending_Payment, Processing, Shipped, Delivered): ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status, client);
            
            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter {i}° item data: ");
                Console.Write("Product Name: ");
                string ProductName = Console.ReadLine();
                Console.Write("Product Price: ");
                double ProductPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int ProductQuantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Product product = new Product(ProductName, ProductPrice);
                OrderItem orderItem = new OrderItem(ProductQuantity, ProductPrice, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order Sumary: ");
            Console.WriteLine(order);
        }
    }
}
