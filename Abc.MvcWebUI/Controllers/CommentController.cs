using Abc.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

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
        public ActionResult ShowCommentsbyProduct(int ProductId)
        {
            var comment = _context.Commments.Where(i => i.ProductId == ProductId).ToList();
            ViewBag.comment = comment;
            return PartialView();
        } 
        public ActionResult ShowCommentsbyUser(string username)
        {
            //var comment = _context.Commments.Where(i => i.UserName == UserName).ToList();
            //ViewBag.comment = comment;
            var comment = _context.Commments.AsNoTracking().ToList(); //Veritabanında değişiklik olmadığı için AsNoTracking
            if (!User.IsInRole("admin"))
                comment = comment.Where(i => i.UserName == username).ToList();
            ViewBag.comment = comment;
            return PartialView();
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