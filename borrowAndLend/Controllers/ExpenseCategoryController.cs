using borrowAndLend.Data;
using borrowAndLend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace borrowAndLend.Controllers
{
    public class ExpenseCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExpenseCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ExpenseCategory> objList = _db.ExpenseCategories;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseCategories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Update(int? id)
        {
            if(id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.ExpenseCategories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Update - post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExpenseCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseCategories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //Get - Delete
        public IActionResult Delete(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.ExpenseCategories.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post - Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.ExpenseCategories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.ExpenseCategories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
