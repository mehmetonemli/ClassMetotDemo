using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(" Musteriler ekleniyor.. ");
            Console.WriteLine(" Musterİ Id : " + customer.Id + " Musteri adi : " + customer.Name + " Musteri Soyadi : " + customer.Surname);
            Console.WriteLine("-----------------------");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(" Musteriler siliniyor.. ");
            Console.WriteLine(" Musterİ Id : "+customer.Id + " Musteri adi : "+customer.Name+" Musteri Soyadi : "+customer.Surname);
            Console.WriteLine("-----------------------");
        }
        public void ListCustomer(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(" Musteriler Listeleniyor , Lütfen Bekleyiniz ");
                Console.WriteLine(" Musteri Id : " + customer.Id +  " Musteri Adı : " + customer.Name + " Musteri Soyadı : " + customer.Surname);
                Console.WriteLine(" Musteriler Listelendi ");
            }
            Console.WriteLine("-----------------------");
        }
    }
}
