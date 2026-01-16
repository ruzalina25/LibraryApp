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

            var book = new Book("1984", "Оруэлл", 1949, 328);
            IBorrowable borrowable = book;
            borrowable.Borrow("Анна");
            borrowable.Borrow("Иван"); // попытка повторного взятия
            borrowable.Return();

        }
    }
}
