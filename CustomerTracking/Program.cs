using System;
using Customers;
using Orders;

namespace Sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      var customer = new Customer();

      customer.Id = 1;
      customer.Name = "John";

      var order = new Order();

      customer.Orders.Add(order);

      Console.WriteLine(customer.Id);
      Console.WriteLine(customer.Name);
      Console.WriteLine(customer.Orders);
    }
  }
}
