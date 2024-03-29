using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WEEK2.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace WEEK2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IBookInterface _bookInterface;

        public HomeController(IBookInterface bookInterface)
        {
            _bookInterface = bookInterface;
        }

        public ViewResult Index()
        {
            var model = _bookInterface.GetAllBooks();
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book book)
        {
            _bookInterface.AddBook(book);
            return RedirectToAction("Index");
            
        }

        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult Update(Book book)
        { 
            _bookInterface.UpdateBook(book);
            return RedirectToAction("Index");

        }


        [HttpPost]
        public IActionResult DeleteUser(int ISBN)
        {
            //Book bookToDelete = book.Find((Book b) => b.ISBN == ISBN);
            var bookToDelete = _bookInterface.GetBookbyId(ISBN);
            _bookInterface.DeleteBook(bookToDelete);
            return RedirectToAction("Index");
        }
        [Route("Home/Index/{isbn}")]
        public ViewResult BookId(int isbn)
        {
            var model= _bookInterface.GetBookbyId(isbn);
            return View(model);
        }
        [Route("Home/Index/Book/{bookname}")]
        public ViewResult BookName(string bookname)
        {
            var model= _bookInterface.GetBookbyName(bookname);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
