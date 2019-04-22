using StorageApp.DataAccess;
using System;

namespace StorageApp.Services
{
    public class ProductsServices
    {
        public static void ProductAdeded()
        {
            Console.WriteLine("***********************************\n" +
                "Добавление наименования продукта: " +
                "\n Введите название:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите производителя:");
            string manufacturer = Console.ReadLine();

            double price = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("***********************************\n" +
                "Добавление наименования продукта: " +
                $"\n Введите название:\n{name}");
                Console.WriteLine($"Введите производителя:\n{manufacturer}");
                Console.WriteLine("Введите цену: ");
                double.TryParse(Console.ReadLine(), out price);
                if (price > 0) break;
            }

            int quantity = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("***********************************\n" +
                "Добавление наименования продукта: " +
                $"\n Введите название:\n{name}");
                Console.WriteLine($"Введите производителя:\n{manufacturer}");
                Console.WriteLine($"Введите цену: \n{price}");
                Console.WriteLine("Введите количество товара: ");
                int.TryParse(Console.ReadLine(), out quantity);
                if (quantity > 0) break;
            }
            StorageTableActions.Add(name, manufacturer, price, quantity);
        }
        public static void ProductDeleted()
        {
            Console.WriteLine("Введите наименование продукта из таблица, которую хотите удалить:");
            string name = Console.ReadLine();
            StorageTableActions.Delete(name);
        }
        public static void ProductUpdated()
        {
            Console.WriteLine("Bведите наименование записи к изменению");
            string oldName = Console.ReadLine();
            Console.WriteLine("Введите новое наименование продукта:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите производителя:");
            string manufacturer = Console.ReadLine();

            double price = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Bведите наименование записи к изменению\n{oldName}");
                Console.WriteLine($"Введите новое наименование продукта:\n{name}");
                Console.WriteLine($"Введите производителя:\n{manufacturer}");
                Console.WriteLine("Введите цену: ");
                double.TryParse(Console.ReadLine(), out price);
                if (price > 0) break;
            }

            int quantity = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Bведите наименование записи к изменению\n{oldName}");
                Console.WriteLine($"Введите новое наименование продукта:\n{name}");
                Console.WriteLine($"Введите производителя:\n{manufacturer}");
                Console.WriteLine($"Введите цену: \n{price}");
                Console.WriteLine("Введите количество товара: ");
                int.TryParse(Console.ReadLine(), out quantity);
                if (quantity > 0) break;
            }

            StorageTableActions.Update(oldName, name, manufacturer, price, quantity);
        }

        public static void ChoiceAction()
        {
            int choice = 0;
            while (choice == 0)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие:\n1.добавить\n2.удалить\n3.обновить\n4.выход");
                int.TryParse(Console.ReadLine(), out choice);
                if (choice <= 0 || choice >= 4) choice = 0;
                else break;
            }

            switch (choice)
            {
                case 1:
                    ProductAdeded();
                    break;
                case 2:
                    ProductDeleted();
                    break;
                case 3:
                    ProductUpdated();
                    break;
            }
        }
    }
}
