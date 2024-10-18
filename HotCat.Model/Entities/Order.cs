using HotCat.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCat.Model.Entities
{
    public class Order:BaseEntity
    {
        //Not: Lazy Loading (Tembel Yükleme) nesnelerin gerektiği zaman yüklenmesini sağlar.

        public Order()  
        {
            OrderDetails = new List<OrderDetail>();
        }


        public DateTime? OrderDate { get; set; } = DateTime.Now;// Orderdate oluşturulurken şu anki tarihi alır
        public decimal? TotalAmount { get; set; }
        
        //public string? CustomerName { get; set; }// Müşteri adı

        //public int? DiscountId { get; set; }

        public virtual List<OrderDetail>? OrderDetails { get; set; } // Sipariş detayları
 
        public Guid? AppUserId { get; set; }//Kullanıcı ID

        public virtual AppUser? AppUser { get; set; } // Müşteriye ait bilgiler

        public int? TableId { get; set; }

        public virtual Table? Table { get; set; }
    }
}
