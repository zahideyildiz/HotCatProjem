using HotCat.BLL.ViewModels.CategoryViewModels;
using HotCat.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotCat.BLL.ViewModels.ProductViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        [Display(Name = "Ürün Ad")]
        [Required(ErrorMessage ="Ürün adı boş geçilemez!")]
        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        [Display(Name = "Ürün Fiyat")]
        [Required(ErrorMessage = "Ürün fiyatı boş geçilemez!")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Ürün Stok")]
        [Required(ErrorMessage = "Ürün stoğu boş geçilemez!")]
        public short UnitsInStock { get; set; }

        [Display(Name = "Ürün Görsel")]
        public string? ImagePath { get; set; }

        [Display(Name = "Durum")]
        public DataStatus Status { get; set; }

        public List<CategoryViewModel>? Categories { get; set; }


    }
}
