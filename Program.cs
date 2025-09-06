using System;
using ECommerceCart.Models;
using ECommerceCart.Services;

namespace ECommerceCart
{
    class Program
    {
        static void Main(string[] args)
        {
            CartService cartService = new CartService();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- E-Commerce Shopping Cart ---");
                Console.WriteLine("1. Add Product to Cart");
                Console.WriteLine("2. Remove Product from Cart");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Checkout");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Product Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter Quantity: ");
                        int qty = int.Parse(Console.ReadLine());
                        cartService.AddToCart(new Product(name, price), qty);
                        break;

                    case "2":
                        Console.Write("Enter Product Name to Remove: ");
                        string removeName = Console.ReadLine();
                        cartService.RemoveFromCart(removeName);
                        break;

                    case "3":
                        cartService.ViewCart();
                        break;

                    case "4":
                        cartService.Checkout();
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
