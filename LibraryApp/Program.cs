using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Models;
using LibraryApp.Services;




namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Библиотека ===");
                Console.WriteLine("1. Добавить книгу");
                Console.WriteLine("2. Добавить журнал");
                Console.WriteLine("3. Показать все");
                Console.WriteLine("4. Поиск по автору");
                Console.WriteLine("5. Выдать книгу");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AddBook(library); break;
                    case "2": AddMagazine(library); break;

                    case "3": ShowAll(library); break;

                    case "4": SearchByAuthor(library); break;

                    case "5": BorrowBook(library); break;

                    case "0": running = false; break;

                    default: Console.WriteLine("Неверный выбор. Нажмите любую клавишу..."); Console.ReadKey(); break;
                }
            }


        }
        static void AddBook(Library library)
        {

            try
            {
                Console.Write("Название: "); string title = Console.ReadLine();
                Console.Write("Автор: "); string author = Console.ReadLine();
                Console.Write("Год: "); int year = int.Parse(Console.ReadLine());
                Console.Write("Страницы: "); int pages = int.Parse(Console.ReadLine());
                library.AddItem(new Book(title, author, year, pages));
                Console.WriteLine("Книга добавлена!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }

        static void AddMagazine(Library library)
        {

            try
            {
                Console.Write("Название: "); string title = Console.ReadLine();
                Console.Write("Автор: "); string author = Console.ReadLine();
                Console.Write("Год: "); int year = int.Parse(Console.ReadLine());
                Console.Write("Страницы: "); int pages = int.Parse(Console.ReadLine());
                library.AddItem(new Book(title, author, year, pages));
                Console.WriteLine(" Журнал добавлен!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }

        static void ShowAll(Library library)
        {
            Console.WriteLine("СПИСОК ВСЕХ ИЗДАНИЙ");
            var items = library.GetAllItems();
            if (items.Count == 0) Console.WriteLine("Библиотека пуста");
            else items.ForEach(i => i.DisplayInfo());
            Console.ReadKey();
        }

        static void SearchByAuthor(Library library)
        {
            Console.WriteLine("Введите имя автора:");
            string author = Console.ReadLine();
            var results = library.GetBooksByAuthor(author);

            Console.WriteLine("Результаты поиска");
            if (results.Count == 0) Console.WriteLine("Книг этого автора не найдено.");
            else results.ForEach(b => b.DisplayInfo());
            Console.ReadKey();
        }

        static void BorrowBook(Library library)
        {
            Console.WriteLine("Введите название книги:");
            string book = Console.ReadLine();
            var results = library.GetAllItems()
                .OfType<Book>()
                .Where(b => b.Title.Equals(book,StringComparison.OrdinalIgnoreCase))
                .ToList();
            Console.WriteLine("Результаты поиска:");
            if (results.Count == 0)
            {
                Console.WriteLine("Книга не найдена");
            }
            else
            {
                var b = results.First();

                b.DisplayInfo();
                if(!b.IsAvailable){
                    Console.WriteLine("Эта книга уже выдана");
                }
                else
                {
                    Console.WriteLine("Введите имя читателя:");
                    string name=Console.ReadLine();
                    try
                    {
                        b.Borrow(name);
                        Console.WriteLine("Книга успешно выдана пользователю");
                    }
                    catch (Exception ex)
                    {
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                    }

                }
            }
                    Console.ReadKey();
        }

    }


}








    

    
