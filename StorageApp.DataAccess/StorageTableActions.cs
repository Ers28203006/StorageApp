using StorageApp.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace StorageApp.DataAccess
{
    public class StorageTableActions : DropCreateDatabaseAlways<DataContext>
    {
        public static void Add(string name, string manufacturer, double price, int quantity)
        {
            using (var context = new DataContext())
            {
                Product product = new Product
                {
                    Name = name,
                    Manufacturer = manufacturer,
                    Price = price,
                    Quantity = quantity
                };

                context.Products.Add(product);
                context.SaveChanges();
                Console.WriteLine("Запись добавлена!");
            }
        }

        public static void Delete(string name)
        {
            using(var context= new DataContext())
            {
                var productName = context.Products.Where(product => product.Name == name).FirstOrDefault();
                context.Products.Remove(productName);
                context.SaveChanges();
                Console.WriteLine("Запись удалена!");
            }
        }

        public static void Update(string oldName, string name, string manufacturer, double price, int quantity)
        {
            using(var context=new DataContext())
            {
                var productName = context.Products.Where(product => product.Name == oldName).FirstOrDefault();
                productName.Name = name;
                productName.Manufacturer = manufacturer;
                productName.Price = price;
                productName.Quantity = quantity;
                context.SaveChanges();
                Console.WriteLine("Запись обновлена!");
            }
        }
    }
}
