using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; } // Her bir ürünün kategorisi olmalı o yüzden bunu ekledim
        public virtual Category Category { get; set; } // Bir ürünün kategori bilgisine ulaşmak için Category türünde bir property ekledim. Böylelikle Category tablosu ile ilişkilendirdim ama bu durumdan Category tablosunun da haberdar olması gerekiyor. Oraya gidip public List<Product> Products { get; set; } ekliyorum

        public List<Order> Orders { get; set; }

    }
}
