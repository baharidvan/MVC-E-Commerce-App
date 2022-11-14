using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using Abc.MvcWebUI.Entity;
using Abc.MvcWebUI.Models;
using PagedList;
using PagedList.Mvc;

namespace Abc.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel() // Veri tabanından gelen ürünleri bir paketleme işlemi yaptık.
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                }).ToList();

            return View(urunler);
        }

        public ActionResult Details(int id, int? SayfaNo)
        {
            
            //ViewBag.comment = comment;
            var product = _context.Products.Where(i => i.Id == id).FirstOrDefault();
            if (Request.IsAjaxRequest())
            {
                int _sayfaNo = SayfaNo ?? 1;
                var comment = _context.Commments.AsNoTracking().Where(i => i.ProductId == id).ToList().ToPagedList<Comment>(_sayfaNo, 5);
                return PartialView("~/Views/Comment/_ShowCommentsbyProduct.cshtml", comment);
            }
            return View(product);
        }

        public ActionResult List(int? id) // Routeconfigten gelen id - Controller/Action/id => Category id
        {
            var urunler = _context.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "1.jpg", //Double question mark means that =>     Image = i.Image != null ? i.Image : "1.jpg"
                    CategoryId = i.CategoryId
                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id); //Category filtrelemesi
            }

            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories() 
        {
            return PartialView(_context.Categories.ToList());//Veritabanına gidip kendi başına çalışan bir view oldu
        }

        public ActionResult AboutUs()
        {
            return View();
        }
    
    }
}