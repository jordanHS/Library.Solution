using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryContext _db;
        public BooksController(LibraryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Books.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}