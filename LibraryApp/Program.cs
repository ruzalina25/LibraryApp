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
            Book myBook = new Book();
            myBook.Title = "1984";
            myBook.Author = "Джордж Оруэлл";
            myBook.Year = 1949;
            myBook.DisplayInfo();


        }
    }
}
