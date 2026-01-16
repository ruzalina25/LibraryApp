using System;
using System.Collections.Generic;
using System.Linq;
using LibraryApp.Models;

namespace LibraryApp.Services
	{
    public class Library
    {
        private readonly List<LibraryItem> _items = new List<LibraryItem>();

        public void AddItem(LibraryItem item) => _items.Add(item);

        public List<LibraryItem> GetAllItems() => new List<LibraryItem>(_items);

        public List<Book> GetBooksByAuthor(string author) {
            {
                return _items
                    .OfType<Book>()
                    .Where(b => b.Author.IndexOf(author,StringComparison.OrdinalIgnoreCase) >=0)
                    .ToList();

            } 
        }
              public List<string> GetModernBookTitles(int yearThreshold = 2000)
              {
                   return _items
                   .OfType<Book>()
                   .Where(b=>b.Year>yearThreshold)
                   .Select(b=>b.Title)
                   .ToList();
              }


    }
    
}
