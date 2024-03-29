using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WEEK2.Models
{
    public class MockBookClass : IBookInterface
    {
         List<Book> books;
        public MockBookClass()
        {
        books = new List<Book>()
        {
            new Book(){ISBN=1,Title="The Famous Indian",Author="Diksha",Price=345.5},
            new Book(){ISBN=2,Title="The Pottery",Author="Shivang",Price=145},
            new Book(){ISBN=3,Title="The Master Piece",Author="Prahalya",Price=400}
        };
        }
        public List<Book> GetAllBooks()
        {
            return books;
        }
        public Book GetBookbyId(int ISBN)
        {
            return books.First((Book b) => b.ISBN == ISBN); 
        }

        public Book GetBookbyName(string bookname)
        {
            return books.First((Book b) => b.Title.ToLower() == bookname.ToLower());
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void UpdateBook(Book book)
        {
                Book bookToUpdate = books.First((Book b) => b.ISBN == book.ISBN);
                bookToUpdate.Title = book.Title;
                bookToUpdate.Author = book.Author;
                bookToUpdate.Price = book.Price;
            
        }

        public void DeleteBook(Book book)
        {
            books.Remove(book);
        }

        

       
    }
}
