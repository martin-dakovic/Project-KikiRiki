using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MVCProjectTest.Models;
using MVCProjectTest.ViewModels;
using Microsoft.AspNet.Identity.Owin;

namespace MVCProjectTest.Controllers
{
    public class ProductController : Controller
    {


        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/Details
        public ActionResult Details()
        {
            Product product = new Product() {id = 5, cijena = "45", name = "Hobotnica"};
            return View(product);
        }

        // GET: Product/Create

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [Authorize]
        public  ActionResult Create(Product product)
        {
            //Obavezno!!!!!!  CONNECTION STRING!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            using (var db = new ProductContext())
            {
               
            ViewBag.maxy = product.name + " " + product.cijena + " " + User.Identity.Name;

                product.user = User.Identity.GetUserId();

                db.Products.Add(product);



                db.SaveChanges();

                return View();
            }

           
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Route("aa/bb")]
        public ActionResult Aa()
        {
            ProductViewModel a = new ProductViewModel() {name = "ikebana", cijena = "beton"};
            return View(a);
        }

    }
}
