using HotCat.Model.Base;
using HotCat.Model.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotCat.Model.Entities
{
    public class OrderDetail:BaseEntity
    {
        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }


        // Mapping

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; } // hangi siparişe ait olduğu

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; } // sipariş edilen ürünün bilgisi
    }
}
