using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
       public void Add(Customer customer)
        {
            Console.WriteLine("-------Inserting User Information---------");
            Console.WriteLine("User ID : " + customer.id);
            Console.WriteLine("User Name : " + customer.CustomerName);
            Console.WriteLine("User Surname : "+ customer.CustomerSurname);
            Console.WriteLine("City : "+ customer.City);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("------User Delete-------");
            Console.WriteLine(customer.CustomerName + " kişisi silindi ");
        }
    }
}
