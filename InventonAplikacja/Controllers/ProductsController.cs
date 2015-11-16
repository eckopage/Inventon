using System.Linq;
using System.Web.Mvc;
using Inventon.DAL.Entities;
using InventonAplikacja.Models;
using InventonAplikacja.Repository.Interfaces;
using AutoMapper;

namespace InventonAplikacja.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProducent _producent;
        private readonly IProduct _product;
        private readonly ICategory _category;

        public ProductsController(IProduct product, IProducent producent, ICategory category)
        {
            _product = product;
            _producent = producent;
            _category = category;
        }

        //
        // GET: /Products/

        public ActionResult Index()
        {
            return View(_product.GetAll());
        }

        //
        // GET: /Products/Details/5

        public ActionResult Details(int id = 0)
        {
            var produkttable = _product.Get(id);
            if (produkttable == null)
            {
                return HttpNotFound();
            }
            return View(produkttable);
        }

        //
        // GET: /Products/Create

        public ActionResult Create()
        {

            var allProds = _producent.GetAllProducents();
            var allCategories = _category.GetAllCategory();

            var categs = (from cat in allCategories
                where cat != null
                select new SelectListItem
                {
                    Value = cat.id.ToString(),
                    Text = cat.KategoriaNazwa
                }).ToList();

            var prods = (from prod in allProds
                where prod != null
                select new SelectListItem
                {
                    Value = prod.id.ToString(), Text = prod.ProducentNazwa
                }).ToList();

            ViewData["products"] = prods;
            ViewData["categories"] = categs;

            return View();
        }

        //
        // POST: /Products/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel produktTable)
        {
            var produktModel = Mapper.Map<ProduktTable>(produktTable);
            if (ModelState.IsValid)
            {
                return _product.Add(produktModel) > 0 ? RedirectToAction("Index") : RedirectToAction("Error","BootstrapBase");             
            }

            return View(produktTable);
        }

        //
        // GET: /Products/Edit/5

        public ActionResult Edit(int id = 0)
        {
            var produkttable = _product.Get(id);
            if (produkttable == null)
            {
                return HttpNotFound();
            }
            return View(produkttable);
        }

        //
        // POST: /Products/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProduktTable produkttable)
        {
            if (ModelState.IsValid)
            {
                _product.Edit(produkttable);
                return RedirectToAction("Index");
            }
            return View(produkttable);
        }

        //
        // GET: /Products/Delete/5

        public ActionResult Delete(int id = 0)
        {
            var produkttable = _product.Get(id);
            if (produkttable == null)
            {
                return HttpNotFound();
            }
            return View(produkttable);
        }

        //
        // POST: /Products/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _product.Delete(id);
            return RedirectToAction("Index");
        }
    }
}