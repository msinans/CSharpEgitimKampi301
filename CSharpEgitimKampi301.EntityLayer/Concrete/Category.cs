using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category // bu sınıf veritabanında ilgili tablolara ait property leri tutuyor
    {
        public int CategoryId { get; set; } // Code Firt de bunun Birincil anahtar ve otomatik artan olması için sınıf adı sonuna Id eklenerek bu property oluşturulmalı
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } // Product tablosu ile ilişkisini oluşturuyorum
    }
}
