using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Models;



namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var items = new List<LibraryItem>
             {
                     new Book("1984", "Оруэлл", 1949, 328),
                     new Magazine("Science", "Редколлегия", 2023, 5),
                    new Book("Анна Каренина", "Толстой", 1877, 850)
             };

            foreach (var item in items)
            {
                item.DisplayInfo();
            }

            /* try
             {
                  Book book1 = new Book("1984", "Дж. Оруэлл", 1949);
                  Book book2 = new Book("Гарри Поттер", "Дж. Роулинг", 1997);
                  Book book3 = new Book("Мастер и Маргарита", "М. Булгаков", 1967);

                 book1.DisplayInfo();
                 book2.DisplayInfo();
                 book3.DisplayInfo();


                 Book bookError = new Book("Неизвестная книга", "неизвестно", -5);
                 bookError.DisplayInfo();

                }
               catch (Exception ex)
                {
                     Console.WriteLine($"Ошибка: {ex.Message}");
                }



             }*/
        }
    }
}
