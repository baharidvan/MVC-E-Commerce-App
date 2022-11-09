using Abc.MvcWebUI.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.MvcWebUI.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }

    }
}
