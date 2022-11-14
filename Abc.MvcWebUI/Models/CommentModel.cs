using Abc.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int ProductId { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
    }
}