using HotCat.Model.Base;
using HotCat.Model.Enums;

namespace HotCat.Model.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public short UnitsInStock { get; set; }

        public string ImagePath { get; set; } //görselin yolu

        public double Discount { get; set; } 

        public ProductStatus Status { get; set; }

        // Mapping

        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; } //Lazy Loading için virtual anahtar kelimesi kullanılmıştır.Lazy Loading kullanılmasının nedeni Product nesnesinin yüklenmesi esnasında Category nesnesinin yüklenmesinin engellenmesidir.Böylelikle veritabanından sırayla bakarak getirmesini sağlar. Virtual ifadesi, Polymorphism (çok biçimlilik) ve Inheritance (kalıtım) kavramlarının uygulanmasına da olanak tanır.



        public virtual List<OrderDetail>? OrderDetails { get; set; }
    }
}
