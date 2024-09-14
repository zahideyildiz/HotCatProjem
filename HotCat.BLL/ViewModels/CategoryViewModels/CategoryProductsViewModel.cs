using HotCat.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotCat.BLL.ViewModels.CategoryViewModels
{
    public class CategoryProductsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }
        [Display(Name = "Birim Fiyatı")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Stok Adedi")]
        public short UnitsInStock { get; set; }
        [Display(Name = "Durum")]
        public DataStatus Status { get; set; }
        [Display(Name = "Aktiflik")]
        public bool IsActive { get; set; }
        [Display(Name = "Fotoğraf Yolu")]
        public string ImagePath { get; set; }
    }
}
