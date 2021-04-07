using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.id = 1;
            customer1.CustomerName = "Mehmet";
            customer1.CustomerSurname = "Kandamar";
            customer1.City = "Gaziantep";

            Customer customer2 = new Customer();
            customer2.id = 2;
            customer2.CustomerName = "Salih";
            customer2.CustomerSurname = "Kılınç";
            customer2.City = "Şanlıurfa";

            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2 };
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Delete(customer1);

        }
    }
}
