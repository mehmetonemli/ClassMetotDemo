using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Semih";
            customer1.Surname = "Çankaya";
            customer1.Age = 25;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Mehmet";
            customer2.Surname = "Önemli";
            customer2.Age = 23;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Elif nur";
            customer3.Surname = "Önemli";
            customer3.Age = 18;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Selim";
            customer4.Surname = "Kaya";
            customer4.Age = 22; 
            
            Customer customer5 = new Customer();
            customer5.Id = 5;
            customer5.Name = "Kerem";
            customer5.Surname = "Say";
            customer5.Age = 19;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.AddCustomer(customer1);
            musteriManager.DeleteCustomer(customer2);
            musteriManager.ListCustomer(customers);

        }
    }
}
