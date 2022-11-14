using Abc.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using Abc.MvcWebUI.Models;

namespace Abc.MvcWebUI.Controllers
{
    public class CommentController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowCommentsbyProduct(int ProductId, int? SayfaNo)
        {
            /*var comment = _context.Commments.Where(i => i.ProductId == ProductId).ToList();
            ViewBag.comment = comment;
            return PartialView();*/
            int _sayfaNo = SayfaNo ?? 1;
            var comment = _context.Commments.AsNoTracking().Where(i => i.ProductId == ProductId).ToList().ToPagedList<Comment>(_sayfaNo, 5);
            //return PartialView(comment); //ShowCommentsbyProduct.cshtml isimli dosya olursa
            return PartialView("~/Views/Comment/_ShowCommentsbyProduct.cshtml", comment);
        } 
        public ActionResult ShowCommentsbyUser(string username, int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;
            //var comment = _context.Commments.AsNoTracking().ToList().ToPagedList<Comment>(_sayfaNo, 5); //Veritabanında değişiklik olmadığı için AsNoTracking
            var comment = _context.Commments.AsNoTracking().ToList().Where(i => i.UserName == username).ToPagedList<Comment>(_sayfaNo, 5);
            if (User.IsInRole("admin"))
            {
                comment = _context.Commments.AsNoTracking().ToList().ToPagedList<Comment>(_sayfaNo, 5);
            }
            //ViewBag.comment = comment;
            //return PartialView(comment);
            //if (Request.IsAjaxRequest())
            //{

            //}
            return PartialView("~/Views/Comment/_ShowCommentsbyUser.cshtml", comment);
        }

        [HttpPost]
        public ActionResult AddComment(Comment _comment, int id)
        {
            //var product = _context.Products.FirstOrDefault(i => i.Id == id);

            var comment = new Comment();

            comment.Content = _comment.Content;
            comment.Date = DateTime.Now;
            comment.ProductId = id;
            comment.UserName = User.Identity.Name;

            _context.Commments.Add(comment);
            _context.SaveChanges();


            return Redirect(Request.UrlReferrer.PathAndQuery); //Return Same Page
        }

        [HttpPost]
        public ActionResult DeleteComment(int id)
        {
            Comment comment = _context.Commments.Find(id);
            _context.Commments.Remove(comment);
            _context.SaveChanges();
            return Redirect(Request.UrlReferrer.PathAndQuery); // Return same page
        }
    }
}