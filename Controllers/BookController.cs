using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Http;
using CRUDusingEntityFremeWk.Data;
using CRUDusingEntityFremeWk.Models;

namespace CRUDusingEntityFremeWk.Controllers
{
    public class BookController : Controller
    {
        ApplicationDbContext Context;
        BookDAL Db;
        public BookController(ApplicationDbContext Context)
        {
            this.Context = Context;
            Db = new BookDAL(Context);
                
        }


        // GET: BookController
        public ActionResult Index()
        {
            return View(Db.GetBooks());
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            var book = Db.GetBookById(id);
            return View(book);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            try
            {
                int result = Db.AddBook(book);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));//List
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = Db.GetBookById(id);
            return View(book);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            try
            {
                int result = Db.UpdateBook(book);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));//List
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = Db.GetBookById(id);
            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = Db.DeleteBook(id);
                if (result >= 1)
                {
                    return RedirectToAction(nameof(Index));//List
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
