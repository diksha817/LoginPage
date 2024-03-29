using System.Collections.Generic;

namespace WEEK2.Models
{
    public interface IBookInterface
    {
        List<Book> GetAllBooks();
        Book GetBookbyId(int ISBN);
        Book GetBookbyName(string bookname);
        public void AddBook(Book book);
        public void UpdateBook(Book book);
        public void DeleteBook(Book book);
    }
}
