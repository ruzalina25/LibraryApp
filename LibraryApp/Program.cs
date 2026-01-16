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
               try
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



            }
        }
}
