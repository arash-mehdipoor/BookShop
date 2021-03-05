using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BookController(ApplicationDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
             var Books = _db.Books;
            return View(Books);
        }
    }
}
