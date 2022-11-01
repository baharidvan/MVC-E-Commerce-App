using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklama")]
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool IsHome { get; set; } //Sadece Anasayfada görüntülenecek ürünler
        public bool IsApproved { get; set; } // Listelenecek ürünler true

        public int CategoryId { get; set; } //foreign key
        public Category Category { get; set; }
    }
}